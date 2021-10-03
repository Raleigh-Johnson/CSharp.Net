using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassAssignment
{

    public class Employee : Person, IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("I quit.");
        }

         public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }   
    }
}       

