using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    // Student periytyy person-luokasta
    class Student : Person
    {
        public string StudentID { get; set; }

        public Student()
        {
        }

        public Student(string firstname, string lastname, string address, string studentID)
            : base(firstname,lastname,address)
        {
            StudentID = studentID;
        }

        public void StudentMethod()
        {
            Console.WriteLine("Learning OOP!");
        }

        //ylikirjoitetaan person luokan tostring metodi
        public override string ToString()
        {
            return base.ToString() + " " + StudentID;
        }


    }
}
