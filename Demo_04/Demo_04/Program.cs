using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Radio is on - what do you want to do?");

            RadioFrequency radiovolume = new RadioVolume();
            radiovolume.Volume = Console.Read();
            Console.WriteLine("Volume is {0}", radiovolume.Volume);

            RadioFrequency radiofrequency = new RadioFrequency();
            radiofrequency.Frequency = Console.Read();
            Console.WriteLine("Frequency is {0}", radiofrequency.Frequency);
        }
    }
}
