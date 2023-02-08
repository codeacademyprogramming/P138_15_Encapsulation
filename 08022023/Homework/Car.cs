using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    internal class Car:Vehicle
    {
        public double FuelCapacity;
        public double CurrentFuel;
        public double FuelFor1Km;

        public override void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Mileage: {Mileage} - FuelCapacity: {FuelCapacity}");
        }
            
        public override void Drive(double distance)
        {
            double neededFuel = distance * FuelFor1Km;

            if (CurrentFuel >= neededFuel)
            {
                CurrentFuel -= neededFuel;
                //Mileage += distance;
                base.Drive(distance);
            }
        }

    }
}
