using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    { 
        public static void Main()
        {
            Person Person1 = new Person(); //Defines Construct
           
            var i = 5;
            Console.WriteLine(i);

            Console.WriteLine($"The instance with the name: { ConstructMe.Name()} and id {ConstructMe.iD}");
            Console.ReadLine();
        }
    }
}

  