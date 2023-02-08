using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car
            {
                Brand = "Mercedes",
                Model = "E200",
                FuelCapacity = 80,
                Mileage = 100,
                CurrentFuel = 25,
                FuelFor1Km = 0.7
            };

            Bicycle bicycle1 = new Bicycle
            {
                Brand = "Steliz",
                Mileage = 10,
                Model = "X10"
            };

            car1.Drive(10);
            car1.Drive(15);
            car1.Drive(25);

            bicycle1.Drive(10);
            bicycle1.Drive(5);
            bicycle1.Drive(14);





            car1.ShowInfo();
            bicycle1.ShowInfo();

            Console.Write("Tarix: ");
            var date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Elave edilecek il:");
            int year = Convert.ToInt32(Console.ReadLine());

            date = date.AddYears(year);
            Console.WriteLine(date.ToString("dd-MM-yyyy HH:mm:ss"));

        }
    }
}
