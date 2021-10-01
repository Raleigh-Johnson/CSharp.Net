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

            Console.WriteLine("Enter a second integer (Optional)");
            string userInput2 = Console.ReadLine();
            Operator obj1 = new Operator();
            if (userInput2 == "")
            {
                int answer1 = obj1.Operation1(userInput1);
                Console.WriteLine(answer1);
            }
            else
            {
                int userInput3 = Convert.ToInt32(userInput2);//User input Int
                int answer1 = obj1.Operation1(userInput1, userInput3);
                Console.WriteLine(answer1);


            }


            Console.ReadLine();
        }
    }
}
