using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Car
    {
        //field variables
        private readonly int maxSpeed = 200;
        private int speed;

        //Property variables
        public int Speed {
            get
            {
                return speed;
            }
            set
            {
                if (value <= maxSpeed) speed = value;
                else
                {
                    Console.WriteLine("Too much Speed - set to max!");
                    speed = maxSpeed;
                }
            }
        }
    }
}
