﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //create one student object
            Student student = new Student("Kirsi","Kernel","Piippukatu 2","K8989");
            Console.WriteLine("Student = " + student.ToString());
        }
    }
}
