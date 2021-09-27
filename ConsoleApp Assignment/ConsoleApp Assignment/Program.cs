using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello. Input a string to be added to the array.");
            string newName = Console.ReadLine();

            string[] names = { "Jeff", "Wiley", "Raleigh", "Tulsa" };

            foreach (string name in names)
            {
                string addName = (name + newName);
                Console.WriteLine(addName);
            }

           


            Console.ReadLine();
        }
    }
}
