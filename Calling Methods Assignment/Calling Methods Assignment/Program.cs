using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calling_Methods_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, enter a number to be put through the operation.");
            int number1 = Convert.ToInt32(Console.ReadLine());
            operate obj1 = new operate();

            int result1 = obj1.Operation1(number1);
            int result2 = obj1.Operation2(number1);
            int result3 = obj1.Operation3(number1);

            Console.WriteLine(result1);
            Console.WriteLine(result2);
            Console.WriteLine(result3);

            Console.ReadLine();
            



        }
    }

}
