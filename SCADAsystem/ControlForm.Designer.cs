namespace SCADAsystem
{
    partial class ControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnStop = new System.Windows.Forms.Button();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.txtHeater = new System.Windows.Forms.TextBox();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtSampling = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSetpoint = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTd = new System.Windows.Forms.TextBox();
            this.txtTi = new System.Windows.Forms.TextBox();
            this.txtKp = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtHeaterAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTemperatureAddress = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFanAddress = new System.Windows.Forms.TextBox();
            this.lableOPC = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOPC = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtOutDAQ = new System.Windows.Forms.TextBox();
            this.txtTempDAQ = new System.Windows.Forms.TextBox();
            this.txtFanDAQ = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lableIOMethod = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbFilter = new System.Windows.Forms.CheckBox();
            this.txtFilterValues = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFan = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(23, 575);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(332, 149);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.LightCoral;
            this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(404, 575);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(332, 149);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // txtTemp
            // 
            this.txtTemp.Enabled = false;
            this.txtTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemp.Location = new System.Drawing.Point(613, 420);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(123, 38);
            this.txtTemp.TabIndex = 2;
            // 
            // txtHeater
            // 
            this.txtHeater.Enabled = false;
            this.txtHeater.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeater.Location = new System.Drawing.Point(23, 379);
            this.txtHeater.Name = "txtHeater";
            this.txtHeater.Size = new System.Drawing.Size(103, 38);
            this.txtHeater.TabIndex = 4;
            // 
            // chart
            // 
            chartArea3.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart.Legends.Add(legend3);
            this.chart.Location = new System.Drawing.Point(6, 6);
            this.chart.Name = "chart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart.Series.Add(series3);
            this.chart.Size = new System.Drawing.Size(740, 311);
            this.chart.TabIndex = 5;
            this.chart.Text = "chart1";
            this.chart.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Temperature";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 356);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Output Power";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtSampling);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtSetpoint);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTd);
            this.groupBox3.Controls.Add(this.txtTi);
            this.groupBox3.Controls.Add(this.txtKp);
            this.groupBox3.Location = new System.Drawing.Point(214, 334);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 204);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PID Controller";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(29, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "Sampling time [ms]";
            // 
            // txtSampling
            // 
            this.txtSampling.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSampling.Location = new System.Drawing.Point(33, 154);
            this.txtSampling.Name = "txtSampling";
            this.txtSampling.Size = new System.Drawing.Size(108, 31);
            this.txtSampling.TabIndex = 13;
            this.txtSampling.Text = "1000";
            this.txtSampling.TextChanged += new System.EventHandler(this.txtSampling_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Setpoint [°C]";
            // 
            // txtSetpoint
            // 
            this.txtSetpoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSetpoint.Location = new System.Drawing.Point(33, 54);
            this.txtSetpoint.Name = "txtSetpoint";
            this.txtSetpoint.Size = new System.Drawing.Size(108, 31);
            this.txtSetpoint.TabIndex = 0;
            this.txtSetpoint.Text = "20";
            this.txtSetpoint.TextChanged += new System.EventHandler(this.txtSetpoint_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Td";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Kp";
            // 
            // txtTd
            // 
            this.txtTd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTd.Location = new System.Drawing.Point(206, 154);
            this.txtTd.Name = "txtTd";
            this.txtTd.Size = new System.Drawing.Size(108, 31);
            this.txtTd.TabIndex = 7;
            this.txtTd.Text = "20";
            this.txtTd.TextChanged += new System.EventHandler(this.txtTd_TextChanged);
            // 
            // txtTi
            // 
            this.txtTi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTi.Location = new System.Drawing.Point(206, 104);
            this.txtTi.Name = "txtTi";
            this.txtTi.Size = new System.Drawing.Size(108, 31);
            this.txtTi.TabIndex = 6;
            this.txtTi.Text = "20";
            this.txtTi.TextChanged += new System.EventHandler(this.txtTi_TextChanged);
            // 
            // txtKp
            // 
            this.txtKp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKp.Location = new System.Drawing.Point(206, 54);
            this.txtKp.Name = "txtKp";
            this.txtKp.Size = new System.Drawing.Size(108, 31);
            this.txtKp.TabIndex = 5;
            this.txtKp.Text = "20";
            this.txtKp.TextChanged += new System.EventHandler(this.txtKp_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtHeaterAddress);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtTemperatureAddress);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtFanAddress);
            this.groupBox2.Controls.Add(this.lableOPC);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtOPC);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(720, 243);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OPC connection";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(374, 165);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "Heater output";
            // 
            // txtHeaterAddress
            // 
            this.txtHeaterAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeaterAddress.Location = new System.Drawing.Point(374, 188);
            this.txtHeaterAddress.Name = "txtHeaterAddress";
            this.txtHeaterAddress.Size = new System.Drawing.Size(267, 26);
            this.txtHeaterAddress.TabIndex = 11;
            this.txtHeaterAddress.Text = "ns=2;s=output";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(374, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "Temperature input";
            // 
            // txtTemperatureAddress
            // 
            this.txtTemperatureAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTemperatureAddress.Location = new System.Drawing.Point(374, 123);
            this.txtTemperatureAddress.Name = "txtTemperatureAddress";
            this.txtTemperatureAddress.Size = new System.Drawing.Size(267, 26);
            this.txtTemperatureAddress.TabIndex = 9;
            this.txtTemperatureAddress.Text = "ns=2;s=temperature";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(374, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Fan input";
            // 
            // txtFanAddress
            // 
            this.txtFanAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFanAddress.Location = new System.Drawing.Point(374, 58);
            this.txtFanAddress.Name = "txtFanAddress";
            this.txtFanAddress.Size = new System.Drawing.Size(267, 26);
            this.txtFanAddress.TabIndex = 7;
            this.txtFanAddress.Text = "ns=2;s=fan_speed";
            // 
            // lableOPC
            // 
            this.lableOPC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lableOPC.AutoSize = true;
            this.lableOPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableOPC.Location = new System.Drawing.Point(83, 123);
            this.lableOPC.Name = "lableOPC";
            this.lableOPC.Size = new System.Drawing.Size(192, 33);
            this.lableOPC.TabIndex = 6;
            this.lableOPC.Text = "Disconnected";
            this.lableOPC.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "OPC host";
            // 
            // txtOPC
            // 
            this.txtOPC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOPC.Location = new System.Drawing.Point(36, 58);
            this.txtOPC.Name = "txtOPC";
            this.txtOPC.Size = new System.Drawing.Size(267, 26);
            this.txtOPC.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtOutDAQ);
            this.groupBox4.Controls.Add(this.txtTempDAQ);
            this.groupBox4.Controls.Add(this.txtFanDAQ);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lableIOMethod);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 278);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(338, 440);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Input/Output";
            // 
            // txtOutDAQ
            // 
            this.txtOutDAQ.Location = new System.Drawing.Point(25, 288);
            this.txtOutDAQ.Name = "txtOutDAQ";
            this.txtOutDAQ.Size = new System.Drawing.Size(166, 26);
            this.txtOutDAQ.TabIndex = 18;
            this.txtOutDAQ.Text = "Dev3/ao0";
            // 
            // txtTempDAQ
            // 
            this.txtTempDAQ.Location = new System.Drawing.Point(25, 221);
            this.txtTempDAQ.Name = "txtTempDAQ";
            this.txtTempDAQ.Size = new System.Drawing.Size(166, 26);
            this.txtTempDAQ.TabIndex = 17;
            this.txtTempDAQ.Text = "Dev3/ai0";
            // 
            // txtFanDAQ
            // 
            this.txtFanDAQ.Location = new System.Drawing.Point(25, 151);
            this.txtFanDAQ.Name = "txtFanDAQ";
            this.txtFanDAQ.Size = new System.Drawing.Size(166, 26);
            this.txtFanDAQ.TabIndex = 16;
            this.txtFanDAQ.Text = "Dev3/ai1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 128);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 20);
            this.label14.TabIndex = 15;
            this.label14.Text = "Fan input";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(139, 20);
            this.label13.TabIndex = 14;
            this.label13.Text = "Temperature input";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 265);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(108, 20);
            this.label12.TabIndex = 13;
            this.label12.Text = "Heater output";
            // 
            // lableIOMethod
            // 
            this.lableIOMethod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lableIOMethod.AutoSize = true;
            this.lableIOMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableIOMethod.Location = new System.Drawing.Point(68, 60);
            this.lableIOMethod.Name = "lableIOMethod";
            this.lableIOMethod.Size = new System.Drawing.Size(176, 33);
            this.lableIOMethod.TabIndex = 5;
            this.lableIOMethod.Text = "DAQ Device";
            this.lableIOMethod.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Location = new System.Drawing.Point(3, 1);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(760, 765);
            this.TabControl.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(752, 739);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFilter);
            this.groupBox1.Controls.Add(this.txtFilterValues);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(394, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 440);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Other";
            // 
            // cbFilter
            // 
            this.cbFilter.AutoSize = true;
            this.cbFilter.Checked = true;
            this.cbFilter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFilter.Location = new System.Drawing.Point(45, 53);
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(63, 24);
            this.cbFilter.TabIndex = 17;
            this.cbFilter.Text = "Filter";
            this.cbFilter.UseVisualStyleBackColor = true;
            this.cbFilter.CheckedChanged += new System.EventHandler(this.cbFilter_CheckedChanged);
            // 
            // txtFilterValues
            // 
            this.txtFilterValues.Location = new System.Drawing.Point(38, 117);
            this.txtFilterValues.Name = "txtFilterValues";
            this.txtFilterValues.Size = new System.Drawing.Size(166, 26);
            this.txtFilterValues.TabIndex = 16;
            this.txtFilterValues.Text = "5";
            this.txtFilterValues.TextChanged += new System.EventHandler(this.txtFilterValues_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 94);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(93, 20);
            this.label16.TabIndex = 15;
            this.label16.Text = "Filter values";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtFan);
            this.tabPage2.Controls.Add(this.chart);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtHeater);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.btnStart);
            this.tabPage2.Controls.Add(this.btnStop);
            this.tabPage2.Controls.Add(this.txtTemp);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(752, 739);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Air Heater";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fan Speed";
            // 
            // txtFan
            // 
            this.txtFan.Enabled = false;
            this.txtFan.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFan.Location = new System.Drawing.Point(23, 470);
            this.txtFan.Name = "txtFan";
            this.txtFan.Size = new System.Drawing.Size(103, 38);
            this.txtFan.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::SCADAsystem.Properties.Resources.PipeBackground;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 569);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 769);
            this.Controls.Add(this.TabControl);
            this.Name = "ControlForm";
            this.Text = "Heat controller";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ControlForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.TextBox txtHeater;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTd;
        private System.Windows.Forms.TextBox txtTi;
        private System.Windows.Forms.TextBox txtKp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtOPC;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lableIOMethod;
        private System.Windows.Forms.Label lableOPC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSetpoint;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHeaterAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTemperatureAddress;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFanAddress;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtSampling;
        private System.Windows.Forms.TextBox txtOutDAQ;
        private System.Windows.Forms.TextBox txtTempDAQ;
        private System.Windows.Forms.TextBox txtFanDAQ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbFilter;
        private System.Windows.Forms.TextBox txtFilterValues;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

