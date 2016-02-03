using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class RadioFrequency
    {
        //field variables
        private readonly double minFrequency = 2000.0;
        private readonly double maxFrequency = 26000.0;
        private double frequency;

        //Property variables
        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if (value <= maxFrequency) frequency = value;
                if (value >= minFrequency) frequency = value;
                else
                {
                    Console.WriteLine("Incorrect frequency - set to max!");
                    frequency = maxFrequency;
                }
            }
        }
    }
}
