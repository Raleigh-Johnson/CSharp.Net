using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    public class Person
    {

        class Persons : Person  // Derived class
        {
            public string FirstName = "Jeff";  // LastName field

            public string LastName = "Wiley";  // LastName field

            public void SayName()             // SayName method 
            {
                Console.WriteLine(FirstName + LastName);
            }
            
        }

    }   
}
