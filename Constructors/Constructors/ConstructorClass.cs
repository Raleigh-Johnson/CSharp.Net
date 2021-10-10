using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class ConstructMe
    { //Identifies proporties 
        public string name;
        public int (string name) : this(name, 123);
        public ConstructMe(string Name, int id)
        {
            this.name = Name;
            this.id = id;
        }

    }
}

