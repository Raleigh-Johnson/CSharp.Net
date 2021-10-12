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
            const string MyName = "Jeff";
            var MyName2 = "Jeffery";
            int iD = 123;
            string Name = "Jesse";
            ConstructMe con = new ConstructMe();
            Console.WriteLine(con.Name + con.iD);
            ConstructMe con1 = new ConstructMe(iD);
            Console.WriteLine(con1.Name + con1.iD);

            ConstructMe con2 = new ConstructMe(Name);
            Console.WriteLine(con2.Name + con2.iD);

            ConstructMe con3 = new ConstructMe(Name, iD);
            Console.WriteLine(con3.Name + con3.iD);



            Console.WriteLine($"The instance with the name: { con.Name } and id { con.iD }");
            Console.ReadLine();
        }
    }
}

  