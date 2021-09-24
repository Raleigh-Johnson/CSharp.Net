using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            int maxWeight = 50;

            Console.WriteLine("Welcome to PackageExpress!");
            Console.WriteLine("Let's gather some info about your package so we can better help you.");
            Console.WriteLine("What is the weight of your package?");
            int weight = Convert.ToInt32(Console.ReadLine()); //Ask user weight of package
            
            string weight > maxWeight == 50 ? "Sorry, Yourpackage is too heavy" : "Awesome, Your package does not exceed our weight limit."; //True or false statment for if the package "weight" exceeds 50

            Console.WriteLine("What is the height of your package?");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

            Console.WriteLine("What is the width of your package?");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();

        }
    }
}
