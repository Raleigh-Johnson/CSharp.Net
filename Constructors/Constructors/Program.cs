using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program : Person
    { 
        public static void Main()
        {
            Person Person1 = new Person(); //Defines Construct
           
            var i = 5;
            Console.WriteLine(i);

            ConstructMe a = new ConstructMe("Raleigh ", 16);
            Console.WriteLine($"The instance with the name: { nameof(Person1)}, has property name: {a.name} and id {a.id}");
            Console.ReadLine();
        }
    }
}

