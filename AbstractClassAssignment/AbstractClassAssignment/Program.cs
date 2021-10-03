using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{
    class Program : Employee
    {

        static void Main(string[] args)
        {
            Employee employee = new Employee();
            IQuittable quitGame = new Employee();
            Employee Emp1 = new Employee(); //instantiate Object
            Emp1.FirstName = "Sample"; //Assigns a value to the FirstName property of the object
            Emp1.LastName = "Student"; //Assigns a value to the LastName property of the object
            Emp1.SayName();  // Calls the "SayName" Method through the object.
            

            quitGame.Quit();
            Console.ReadLine();



            
        }
    }
}