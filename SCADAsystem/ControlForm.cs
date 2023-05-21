using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Opc.UaFx;
using Opc.UaFx.Client;
using System.IO;
using System.Xml;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Linq;

namespace SCADAsystem
{
    public partial class ControlForm : Form
    {
        string configfile = String.Format(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + "\\Configuration.xml");
        OpcClient client;
        bool OPCConnected = false;
        public static Thread simThread = new Thread(Simulator.Run);
        

        public ControlForm()
        {
            InitializeComponent();
            LoadConfig(configfile);
            AirHeater.NewSetpoint(Convert.ToDouble(txtSetpoint.Text));
            SetupLineChart();
            AirHeater.FilterOn(true);
            AirHeater.setFiltervalue(5);
            AirHeater.chartedValues = 500;
            simThread.Name = "Simthread";
            if (AirHeater.Simulate())
            {
                simThread.Start();
            }
        }

        // User interface events
        // # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # 
        //
        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            btnStart.Enabled = false;
            ConnectToOPC();
            timer.Start();
            txtFanAddress.Enabled = false;
            txtHeaterAddress.Enabled = false;
            txtTemperatureAddress.Enabled = false;
            txtFanDAQ.Enabled = false;
            txtOutDAQ.Enabled = false;
            txtTempDAQ.Enabled = false;
            AirHeater.setIOAddresses(txtFanDAQ.Text, txtTempDAQ.Text, txtOutDAQ.Text);
            AirHeater.ChangeAddress(txtFanDAQ.Text, txtTempDAQ.Text, txtOutDAQ.Text);

        }

        
        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            try
            {
                client.Disconnect();
            }
            catch (Exception)
            {
            }
            lableOPC.Text = "Disconnected";
            OPCConnected = false;
            timer.Stop();
            txtFanAddress.Enabled = true;
            txtHeaterAddress.Enabled = true;
            txtTemperatureAddress.Enabled = true;
            txtFanDAQ.Enabled = true;
            txtOutDAQ.Enabled = true;
            txtTempDAQ.Enabled = true;
        }


        
        private void txtSetpoint_TextChanged(object sender, EventArgs e)
        {
            KeepNumber(txtSetpoint);
            if (txtSetpoint.Text.Length > 0)
            {
                AirHeater.NewSetpoint(Convert.ToDouble(txtSetpoint.Text));
            }
        }


        private void txtSampling_TextChanged(object sender, EventArgs e)
        {
            KeepNumber(txtSampling);
            if (txtSampling.Text.Length > 0)
            {
                if (Convert.ToInt32(txtSampling.Text) > 1)
                {
                    timer.Interval = Convert.ToInt32(txtSampling.Text);

                }
                else
                {
                    timer.Interval = 2;
                }
            }
        }


        private void txtKp_TextChanged(object sender, EventArgs e)
        {
            KeepNumber(txtKp);
            if (txtKp.Text.Length > 0)
            {
                AirHeater.setPParam(Convert.ToDouble(txtKp.Text));
            }
        }

        private void txtTi_TextChanged(object sender, EventArgs e)
        {
            KeepNumber(txtTi);
            if (txtTi.Text.Length > 0)
            {
                AirHeater.setIParam(Convert.ToDouble(txtTi.Text));
            }
        }

        private void txtTd_TextChanged(object sender, EventArgs e)
        {
            KeepNumber(txtTd);
            if (txtTd.Text.Length > 0)
            {
                AirHeater.setDParam(Convert.ToDouble(txtTd.Text));
            }
        }

        // Settings tab
        // # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # 
        //
        private void cbFilter_CheckedChanged(object sender, EventArgs e)
        {
            AirHeater.FilterOn(cbFilter.Checked);
        }

        private void txtFilterValues_TextChanged(object sender, EventArgs e)
        {
            KeepNumber(txtFilterValues);
            if (txtFilterValues.Text.Length > 0)
            {
                AirHeater.setFiltervalue(Convert.ToInt32(txtFilterValues.Text));
            }
        }




        // Other methods
        // # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # 
        //

        private void timer_Tick(object sender, EventArgs e)
        {

            txtTemp.Text = AirHeater.ReadTemp() + " °C";
            txtFan.Text = AirHeater.ReadFan() + " %";
            txtHeater.Text = AirHeater.ControlHeater(timer.Interval) + " %";
            AirHeater.SetHeater();
            if (OPCConnected)
            {
                try
                {
                    client.WriteNode(txtFanAddress.Text, Convert.ToInt32(txtFan.Text.Substring(0,txtFan.Text.Length-2)));
                    client.WriteNode(txtTemperatureAddress.Text, Convert.ToDouble(txtTemp.Text.Substring(0, txtTemp.Text.Length - 3)));
                    client.WriteNode(txtHeaterAddress.Text, Convert.ToInt32(txtHeater.Text.Substring(0, txtHeater.Text.Length - 2)));

                }
                catch (Exception)
                {
                    OPCConnected = false;
                    lableOPC.Text = "Disconnected";
                    MessageBox.Show("Could not write to OPC server. Check if the server is running and that the variable addresses corresponds", "Write Error");
                }
            }
            DrawChart(AirHeater.GetTimeValues(), AirHeater.GetHistoricalValues());


        }

        public void DrawChart(List<DateTime> xValues, List<double> yValues)
        {
            chart.Visible = true;
            chart.Series["Temperature"].Points.Clear();
            // add the new data points to the chart
            for (int i = 0; i < xValues.Count; i++)
            {
                chart.Series["Temperature"].Points.AddXY(xValues[i], yValues[i]);
            }
            chart.ChartAreas[0].AxisY.Minimum = yValues.Min()-0.1;
            chart.ChartAreas[0].AxisY.Maximum = yValues.Max() + 0.1;

        }


        private void SetupLineChart()
        {
            // set the chart title and axis labels
            chart.Titles.Add("Output Temperature From The Airheater");
            chart.ChartAreas[0].AxisX.Title = "Time";
            chart.ChartAreas[0].AxisY.Title = "Temperature";
            chart.Legends[0].Enabled = false;

            // set the chart type to line
            chart.Series.Clear();
            chart.Series.Add("Temperature");
            chart.Series["Temperature"].ChartType = SeriesChartType.Line;
            chart.Series["Temperature"].Color = Color.Red;

            // set the x-axis to display dates and times
            chart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
            chart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;

            // set the label format
            chart.ChartAreas[0].AxisY.LabelStyle.Format = "{0.00}°C";
        }
        

        private void ControlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (OPCConnected)
            {
                client.Disconnect();
            }
            lableOPC.Text = "Disconnected";

            if (simThread.IsAlive)
            {
                simThread.Abort();
            }
        }

        public void KeepNumber(TextBox box)
        {
            if (box.Text.Length > 0)
            {
                try 
                {  Convert.ToDouble(box.Text); 
                }
                catch (Exception e) 
                { 
                    box.Text = box.Text.Substring(0, box.Text.Length-1); 
                }
            }
            
            try { Convert.ToDouble(box.Text); }
            catch (Exception)
            { box.Text = ""; }
        }


        // OPC
        // # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # 
        //


        public void ConnectToOPC()
        {
            try
            {
                client = new OpcClient(txtOPC.Text);
                lableOPC.Text = "Connecting...";
                client.Connect();
                lableOPC.Text = "Connected";
                client.OperationTimeout = 20000;
                OPCConnected = true;
            }
            catch (Exception e) 
            {
                MessageBox.Show(String.Format("{0}", e.Message), "Failed to connect to OPC");
                lableOPC.Text = "Disconnected";
                OPCConnected = false;
            }
        }



        public void LoadConfig(string configPath)
        {
            XmlReader reader = XmlReader.Create(configPath);
            reader.ReadToFollowing("OPC");
            txtOPC.Text = reader.GetAttribute("address");

            reader.ReadToFollowing("pid");
            double kp = Convert.ToDouble(reader.GetAttribute("kp"));
            double ti = Convert.ToDouble(reader.GetAttribute("ti"));
            double td = Convert.ToDouble(reader.GetAttribute("td"));

            txtKp.Text = kp.ToString("0.###");
            txtTi.Text = ti.ToString("0.###");
            txtTd.Text = td.ToString("0.###");
            AirHeater.setPParam(Convert.ToDouble(txtKp.Text));
            AirHeater.setIParam(Convert.ToDouble(txtTi.Text));
            AirHeater.setDParam(Convert.ToDouble(txtTd.Text));
            Console.WriteLine(kp + " -- " + ti + " -- " + td);

            reader.ReadToFollowing("IO");
            lableIOMethod.Text = reader.GetAttribute("method");
            AirHeater.Method(lableIOMethod.Text);


        }

        
    }
}
