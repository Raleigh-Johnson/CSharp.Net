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

        public static bool operator ==(Employee Id1, Employee Id2)
        {

            bool result = Id1.Id == Id2.Id;
            return result;

        }

        public static bool operator !=(Employee Id1, Employee Id2)
        {

            bool result = Id1.Id != Id2.Id;
            return result;

        }



        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }   
    }
}       

