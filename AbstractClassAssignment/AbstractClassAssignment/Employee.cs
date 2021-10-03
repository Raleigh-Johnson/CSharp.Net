using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{

    public class Employee : Person, IQuittable // Base class
    {
        IQuittable
           
         public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }   
    }
}       

