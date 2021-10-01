using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, enter an integer to be put through the operation.");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("Enter a second integer (Optional)");
                int userInput2 = Convert.ToInt32(Console.ReadLine());//User input Int
            }
            catch (InvalidProgramException ex)
            {
                string userInput2 = Convert.ToInt32(Console.ReadLine());//User input Int
            }
            Operator obj1 = new Operator();
            int answer1 = obj1.Operation1(userInput1,userInput2);
            Console.WriteLine(answer1);

            Console.ReadLine();
        }
    }
}s
