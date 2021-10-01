using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, enter an integer to be put through the operation.");
            int number1 = Convert.ToInt32(Console.ReadLine());//User input Int
            Class1 obj1 = new Class1();
            int answer1 = obj1.Operation1(number1);
            Console.WriteLine(answer1);//Writes answer after being affected by operator


            Console.WriteLine("Hello, enter a decimal to be put through the operation.");
            decimal number2 = Convert.ToDecimal(Console.ReadLine());//Converts string to decimal
            decimal answer2 = obj1.Operation2(number2);
            Console.WriteLine(answer2);//Writes answer after being affected by operator

            Console.WriteLine("Hello, enter a string to be put through the operation.");
            string number3 = Console.ReadLine();
            int answer3 = obj1.Operation3(number3);
            Console.WriteLine(answer3);//Writes answer after being affected by operator



            Console.ReadLine();
        }
    }
}
