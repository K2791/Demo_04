﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Speed = 300;
            car.maxSpeed = 300;
            Console.WriteLine("Speed is {0}", car.Speed);
        }
    }
}
