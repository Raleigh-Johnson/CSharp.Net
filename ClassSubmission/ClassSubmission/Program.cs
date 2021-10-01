using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, enter an integer to be put through the operation.");
            int userInput1 = Convert.ToInt32(Console.ReadLine());//userInput1
            VoidClass obj1 = new VoidClass();
            obj1.Operation(userInput1);//Normal Method
            Console.WriteLine("Hello, enter an decimal to be put through the operation.");
            decimal userInput2 = Convert.ToDecimal(Console.ReadLine());
            obj1.Operation(userInput2);//Overloaded Method

            Console.ReadLine();
        }
    }
}
