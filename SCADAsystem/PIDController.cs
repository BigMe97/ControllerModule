using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCADAsystem
{
    class PIDController
    {
        private double kp;
        private double ti;
        private double td;
        private double lastError = 0;
        private double sumError = 0;
        private double lastOut = 0;
        private double maxError = 15;
        private double upperLim = 5, lowerLim = 0;
        private DateTime lastTime = DateTime.Now;
        

        public PIDController()
        {

        }

        public void setPParam(double Kp)
        {
            this.kp = Kp;
        }


        public void setIParam(double Ti)
        {
            if (Ti >= 0)
            {
                this.ti = Ti;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Cannot control with negative time parameters");
            }
        }


        public void setDParam(double Td)
        {
            if (Td >= 0)
            {
                this.td = Td;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Cannot control with negative time parameters");
            }
        }

        public double Control(double feedbackValue, double setpoint, int deltaTime)
        {
            double dt = deltaTime / 1000.0;
            double error = setpoint - feedbackValue;
            double P = error * this.kp;
            double I = (this.kp / this.ti) * dt * (this.sumError + error);
            double D = this.kp * this.td * (error - this.lastError) / dt;
            this.lastOut = this.lastOut + P + I + D;
            // If this is the first instance in a while
            // handle it as the first time
            if (DateTime.Now > this.lastTime.AddMilliseconds(deltaTime*20))
                this.lastOut = error;
            // Constrain within output range
            if (this.lastOut > this.upperLim)
                this.lastOut = this.upperLim;
            else if (lastOut < this.lowerLim)
                this.lastOut = this.lowerLim;

            this.lastError = error;
            this.sumError += error;
            // Avoid too large error sums
            if (sumError > maxError)
                this.sumError = this.maxError;
            else if (this.sumError < -this.maxError)
                this.sumError = -this.maxError;
            this.lastTime = DateTime.Now;

            return lastOut;
        }
    }
}
