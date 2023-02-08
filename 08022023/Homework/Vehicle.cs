using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Vehicle
    {
        public double Mileage;
        public string Brand;
        public string Model;

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Mileage: {Mileage}");
        }

        public virtual void Drive(double distance)
        {
            Mileage += distance;
        }
    }
}
