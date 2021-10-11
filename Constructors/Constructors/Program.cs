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
            ConstructMe con = new ConstructMe();
            Console.WriteLine($"The instance with the name: { con.Name } and id { con.iD }");
            Console.ReadLine();
        }
    }
}

  