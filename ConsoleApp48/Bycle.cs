using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp48
{
    internal class Bycle:Vehicle
    {
        public override void Drive(double km)
        {
            Milage += km;
            Console.WriteLine("{0} km sonra umumi qet olunmus mesafe {1} olacaq", km, Milage);
        }
    }
}
