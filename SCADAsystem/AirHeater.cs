using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NationalInstruments.DAQmx;
using System.IO.Ports;
using Task = NationalInstruments.DAQmx.Task;
using System.Windows.Forms;
using System.Threading;
using Org.BouncyCastle.Bcpg.OpenPgp;

namespace SCADAsystem
{

    static class AirHeater
    {
        private static double currentTemp;
        private static double output;
        private static double fan;
        private static double setpoint;
        private static string fanAddress;
        private static string outputAddress;
        private static string tempAddress;
        private static bool FilterTemperature;
        private static int filtervalue;
        private static PIDController Controller = new PIDController();
        private static TemperatureSensor temp = new TemperatureSensor();
        private static List<DateTime> TimeValues = new List<DateTime>();
        private static List<double> HistoricalValues = new List<double>();
        private static string method;
        private static SerialPort port = new SerialPort("COM1", 115200);
        public static int chartedValues;


        public static string ReadTemp()
        {
            switch (method)
            {
                case "Arduino":
                    currentTemp = ReadArduinoTemp();
                    break;

                case "Simulator":
                    currentTemp = ReadSimulatorTemp();
                    break;

                case "USB-6008":
                    currentTemp = ReadDAQTemp();
                    break;

                default:
                    throw new Exception($"{method} is not a valid method\nPlease correct the config file");
                    break;
            }

            if (FilterTemperature)
            {
                currentTemp = Filter(currentTemp);
            }

            HistoricalValues.Add(currentTemp);
            TimeValues.Add(DateTime.Now);
            if (HistoricalValues.Count > chartedValues)
            {
                HistoricalValues.RemoveAt(0);
                TimeValues.RemoveAt(0);
            }

            return currentTemp.ToString("0.##");
        }


        private static double Filter(double newVal)
        {
            if (HistoricalValues.Count >= filtervalue)
            {
                for (int i = HistoricalValues.Count-1; i > HistoricalValues.Count-filtervalue; i--)
                {
                    newVal += HistoricalValues[i];
                }
                newVal = newVal / (filtervalue);
            }
            else
            {
                for (int i = HistoricalValues.Count; i > 0; i--)
                {
                    newVal += HistoricalValues[i-1];
                }
                newVal = newVal / (HistoricalValues.Count+1);
            }
            return newVal;
        }



        public static string ReadFan()
        {
            switch (method)
            {
                case "Arduino":
                    fan = ReadArduinoFan();
                    break;

                case "Simulator":
                    fan = ReadSimulatorFan();
                    break;

                case "USB-6008":
                    fan = ReadDAQFan();
                    break;

                default:
                    throw new Exception($"{method} is not a valid method\nPlease correct the config file");
            }
            fan = Math.Round(fan / 5.0) * 5;
            return fan.ToString("0");
        }


        public static string ControlHeater(int samplingTime)
        {
            if (fan > 0)
            {
                output = Controller.Control(currentTemp, setpoint, samplingTime);
            }
            else
            {
                output = 0;
            }
            return (output*20).ToString("0");
        }


        public static void SetHeater()
        {
            switch (method)
            {
                case "Arduino":
                    WriteArduinoHeater(output);
                    break;

                case "Simulator":
                    WriteSimulatorHeater(output);
                    break;

                case "USB-6008":
                    WriteDAQHeater(output);
                    break;

                default:
                    break;
            }
        }

        public static void setIOAddresses(string fanAdr, string tempAdr, string outAdr)
        {
            fanAddress = fanAdr;
            tempAddress = tempAdr;
            outputAddress = outAdr;
        }

        public static List<DateTime> GetTimeValues()
        {
            return TimeValues;
        }
        public static List<double> GetHistoricalValues()
        {
            return HistoricalValues;
        }


        // Set Parameters and settings
        // # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # #
        // 
        public static void NewSetpoint(double set)
        {
            setpoint = set;
        }

        public static void setPParam(double Pparam)
        {
            Controller.setPParam(Pparam);
        }

        public static void setIParam(double Iparam)
        {
            Controller.setIParam(Iparam);
        }

        public static void setDParam(double Dparam)
        {
            Controller.setDParam(Dparam);
        }

        public static void FilterOn(bool on)
        {
            FilterTemperature = on;
        }

        public static void setFiltervalue(int val)
        {
            filtervalue = val;
        }

        public static void ChangeAddress(string addressFan, string addressTemp, string addressOut)
        {
            fanAddress = addressFan;
            tempAddress = addressTemp;
            outputAddress = addressOut;
        }



        public static void Method(string newMethod)
        {
            method = newMethod;
        }

        public static bool Simulate()
        {
            return (method == "Simulator");
        }

        // Simulator
        // # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # #
        //
        public static double ReadSimulatorTemp()
        {
            double reading = Simulator.GetTemp();
            return reading;
        }
        public static double ReadSimulatorFan()
        {
            double reading = 100;
            return reading;
        }

        public static void WriteSimulatorHeater(double analogOutput)
        {
            Simulator.SetVoltage(output);
        }


        // Arduino
        // # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # #
        //
        


        public static double ReadArduinoTemp()
        {
            double reading = 0;

            string read = port.ReadLine();
            try
            {
                Console.WriteLine(read);
                reading = Convert.ToDouble(read);
            }
            catch (Exception)
            {
                reading = currentTemp;
                Console.WriteLine($"None available: {reading}");
            }

            return reading;
        }


        public static double ReadArduinoFan()
        {
            double reading = 0;
            return reading;
        }

        public static void WriteArduinoHeater(double analogOutput)
        {
            analogOutput = Math.Round((255 * analogOutput) / 100);
            Console.WriteLine($"Output: {analogOutput}");
            port.WriteLine(analogOutput.ToString());
        }
        
        // DAQ device
        // # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # # #
        //

        public static double ReadDAQTemp()
        {
            Task analogInTask = new Task();
            AIChannel myAIChannel;
            myAIChannel = analogInTask.AIChannels.CreateVoltageChannel(tempAddress, "myAIChannel", AITerminalConfiguration.Rse, 1, 5, AIVoltageUnits.Volts);
            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask.Stream);
            double analogDataIn = reader.ReadSingleSample();
            return (analogDataIn - 1) * 12.5;
        }

        public static double ReadDAQFan()
        {
            Task analogInTask = new Task();
            AIChannel myAIChannel;
            myAIChannel = analogInTask.AIChannels.CreateVoltageChannel(fanAddress, "myAIChannel", AITerminalConfiguration.Rse, 1, 5, AIVoltageUnits.Volts);
            AnalogSingleChannelReader reader = new AnalogSingleChannelReader(analogInTask.Stream);
            double analogDataIn = reader.ReadSingleSample();
            return (analogDataIn - 2.4) * 40;
        }

        public static void WriteDAQHeater(double analogOutput)
        {
            Task analogOutTask = new Task();
            AOChannel myAOChannel;
            myAOChannel = analogOutTask.AOChannels.CreateVoltageChannel(outputAddress, "myAOChannel", 0, 5, AOVoltageUnits.Volts);
            AnalogSingleChannelWriter writer = new
            AnalogSingleChannelWriter(analogOutTask.Stream);
            writer.WriteSingleSample(true, analogOutput);


        }


    }
}
