using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
   public class  
    { //Identifies proporties 
        public ConstructMe(string name) : this(name, 123) 
        {
        }
        public ConstructMe(int id) : this("Bob", id)
        {
        }
        public ConstructMe(string name, int id)
        {
            this.name = Name;
            this.id = iD;
        }




    }
}
