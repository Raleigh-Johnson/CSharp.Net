using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    
    public class Employee : Person  // Base class
    {
        public void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }


     
          
    }       
}
