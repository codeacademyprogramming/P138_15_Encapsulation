using System;
using Lesson1;


namespace Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();

            product1.Name = "Milla Ayran 1L";

            product1.SetPrice(-10);
            product1.SetPrice(100);
            product1.SetPrice(20);

            product1.Price = 45;
            product1.Price = -10;

            product1.DiscountPercent = -20;

            Console.WriteLine(product1.Price);
            Console.WriteLine(product1.GetPrice());
            Console.WriteLine(product1.DiscountPercent);


            Drink drink1 = new Drink
            {
                Name = "Coca cola 1L",
                AlcoholPercent = 0
            };

            drink1.Price = 10;
            drink1.Price = -20;
            drink1.Price = 2;



            Console.WriteLine(drink1.Price);
        }


    }
}
