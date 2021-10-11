using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
   public class ConstructMe 
    { //Identifies proporties
      //
        public string Name { get; set; }
        public int iD { get; set; }

        public ConstructMe(string name) : this(name, 123) 
        {
        }
        public ConstructMe(int id) : this("Bob", id)
        {
            Console.WriteLine(Name + iD);
        }
        public ConstructMe(string name, int id)
        {
            name = Name;
            id = iD;
        }




    }
}
