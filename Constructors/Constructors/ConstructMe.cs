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
        public ConstructMe()
        {

        }
        public ConstructMe(string Name) : this()
        {
            this.Name = Name;
        }
        public ConstructMe(string Name, int iD)
        : this(Name)
        {
            this.iD = iD;
        }
    }
}





    

