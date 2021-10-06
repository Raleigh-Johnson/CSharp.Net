using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DT1 = DateTime.Now;
            Console.WriteLine(DT1); //Prints the current time
            Console.ReadLine();
            Console.WriteLine("Please input a number"); //Asks the user for an integer input
            float Input = float.Parse(Console.ReadLine());// assigns the users input to "Input"
            DateTime TimeUser = DT1.AddHours(Input);
            Console.WriteLine("In {0} Hours, the time will read {1}",Input, TimeUser); //DateTime.Hour
            Console.ReadLine();



        }
    }
}
