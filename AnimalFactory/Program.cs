
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Choose one continent:\n1.America\n2.Africa\n3.Australia\n4.Eurasia");
                string choice = Console.ReadLine();

                AbstractFactory abstractFactory = null;

                if (choice == "1") abstractFactory = new AmericanFactory();
                else if (choice == "2") abstractFactory = new AfricanFactory();
                else if (choice == "3") abstractFactory = new AfricanFactory();
                else if (choice == "4") abstractFactory = new AfricanFactory();
                else Console.WriteLine("Wrong choice!");

                Console.WriteLine($"Name: {abstractFactory.CreateCarnivores().Name}");
                Console.WriteLine($"Eating Meat: {abstractFactory.CreateCarnivores().IsEatingMeat}\n");

                Console.WriteLine($"Name: {abstractFactory.CreateHerbivores().Name}");
                Console.WriteLine($"Eating Plant {abstractFactory.CreateHerbivores().IsEatingPlant}\n");
                Console.ReadLine();

            }
        }
    }
}
