using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp48
{
    internal abstract class Vehicle
    {
        public string Color;
        public string Brand;
        public double Milage;
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Color:{Color}+ +Brand:{Brand}+ +Milage:{Milage}");
        }
        public abstract void  Drive(double km);
    }
}
