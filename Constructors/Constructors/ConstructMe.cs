using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    public class ConstructMe
    {
        public string Name { get; set; }
        public int iD { get; set; }
        public ConstructMe() : this("Jeff" , 123)
        {

        }
        public ConstructMe(string /*Name*/) : this(Name, 456)
        {
        }
        public ConstructMe(int iD) : this("Jeff", iD)
        {
        }
        public ConstructMe(string Name, int iD)
        {
            this.iD = iD;
            this.Name = Name;
        }
    }
}





    

