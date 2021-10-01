using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, enter an integer to be put through the operation.");
            int userInput1 = Convert.ToInt32(Console.ReadLine());//userInput1
            Console.WriteLine("Hello, enter an integer to be put through the operation.");
            int userInput2 = Convert.ToInt32(Console.ReadLine());//userInput2
            VoidClass obj1 = new VoidClass();
            obj1.Operation(userInput1, userInput2);
            obj1.Operation(userInput1: 3,userInput2: 4);

            Console.ReadLine();


        
        }
    }
}
    

