using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp48
{
    internal class Car : Vehicle
    {
        public double _fuelCapacity;
        public double _currentFuel;
        public double _fuelFor1km;

        public Car(string color, string brand, double milage, double fuelcapacity, double currentfuel, double fuelfor1km)
        {
            Color = color;
            Brand = brand;
            Milage = milage;
            FuelCapacity = fuelcapacity;
            CurrentFuel = currentfuel;
            FuelFor1km = fuelfor1km;
        }

        public double FuelCapacity
        {
            get=>this._fuelCapacity;
            set
            {
                if (value>=0)
                {
                    this._fuelCapacity = value;
                }
            }
        }
        public double CurrentFuel
        {
            get => this._currentFuel;
            set
            {
                if (value >= 0)
                {
                    this._currentFuel = value;
                }
            }
        }
        public double FuelFor1km
        {
            get => this._fuelFor1km;
            set
            {
                if (value >= 0)
                {
                    this._fuelFor1km = value;
                }
            }
        }
        public override void Drive(double km)
        {
            throw new NotImplementedException();
        }
        public string GetInfo()
        {
            return $"Rengi:{this.Color} /-/ Brand Modeli:{this.Brand} /-/ Hal-hazirki km-i:{this.Milage} /n Maksimum yanacaq tutumu:{this.FuelCapacity} /-/ Hal-hazirda movcud olan yanacaq tutumu{this.CurrentFuel} /-/ 1km-e istifade etdiyi yanacaq:{this.FuelFor1km}/n";
        }
    }
}
