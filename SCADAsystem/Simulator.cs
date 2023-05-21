using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SCADAsystem
{
    public static class Simulator
    {
        private static int Tau = 22;
        private static int Tdelay = 2;
        private static double Kgain = 3.5;
        private static double Tenv = 22.0;
        private static double[] UArray;
        public static double U;
        private static double time;
        private static double lastTime;
        private static DateTime originTime;
        private static int samplingTime = 500;
        private static int storedSamples = Tdelay * 1000 / samplingTime;

        private static double Temperature;

        public static void Run()
        {
            U = 0;
            Temperature = Tenv;
            originTime = DateTime.Now.ToUniversalTime();
            lastTime = GetTime();
            UArray = new double[storedSamples];

            while (true)
            {

                for (int i = 0; i < storedSamples-1; i++)
                {
                    UArray[i] = UArray[i + 1];
                }
                UArray[storedSamples - 1] = U;
                
                Temperature = Temperature + deltaT()*(time - lastTime)/1000;
                lastTime = time;
                
                Console.WriteLine(Temperature);

                while (time < lastTime + samplingTime)
                {
                    time = GetTime();
                }
            }
        }


        public static double GetTime()
        {
            TimeSpan diff = DateTime.Now.ToUniversalTime() - originTime;
            return Math.Floor(diff.TotalMilliseconds);
        }

        private static double deltaT()
        {
            double dt = (1.0 / Tau) * (-Temperature + (Kgain * UArray[0]) + Tenv);
            return dt;
        }

        public static void SetVoltage(double V)
        {
            U = V;
        }

        public static double GetTemp()
        {
            // Add noise
            Random r = new Random();
            return Temperature + (r.NextDouble()/20)-0.025;
        }


    }
}
