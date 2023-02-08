using System;

namespace Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human hm1 = new Human();
            hm1.Name = "Hikmet";
            hm1.Age = 200;
            hm1.Age = 100;
            hm1.Age = 80;


            Console.WriteLine(hm1.Age);

            Student std1 = new Student
            {
                GroupNo = "P123",
                Name = "Hikmet"
            };

            std1.Age = 25;


            Console.WriteLine(std1.Age);
        }
    }
}
