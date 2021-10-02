using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee(); //Substantiate Object
            Emp1.FirstName = "Raleigh"; //Assigns a value to the FirstName property of the object
            Emp1.LastName = "Johnson"; //Assigns a value to the LastName property of the object
            Emp1.Id = 1234;
            Emp1.SayName();  // Calls the "SayName" Method through the object.
            Console.ReadLine();
        }
    }
}
