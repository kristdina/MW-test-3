using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
           
            Console.WriteLine("Whats your name?");
            string nameText = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("What is your phone Brand?");
            string brandText = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("What is your phone Model?");
            string modelText = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("What is your phone Size?");
            string sizeText = Console.ReadLine();
            int size = int.Parse(sizeText);

            phone.Name = nameText;
            phone.Brand = brandText;
            phone.Model = modelText;
            phone.Size = 6;

            Console.WriteLine("");

            string greeting = phone.GetGreeting();

            Console.WriteLine(greeting);

            Console.WriteLine("");

            Console.WriteLine("");

            Car car = new Car();

            Console.WriteLine("What is yours car Brand?");
            string carbrandText = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Kāda ir Tavas mašīnas nummurzīme?");
            string carnumberText = Console.ReadLine();
            
            car.carBrand = carbrandText;
            car.carNumber = carnumberText;

            Console.WriteLine("");

            string greeting2 = car.GetGreeting();

            Console.WriteLine(greeting2);

            Console.WriteLine("");
        }
    }
}
