using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using NationalInstruments.DAQmx;
using Task = NationalInstruments.DAQmx.Task;

namespace SCADAsystem
{
    
    class TemperatureSensor
    {
        public double GetTemperature()
        {
            double temperature = 20;
            return temperature;
        }
    }
}
