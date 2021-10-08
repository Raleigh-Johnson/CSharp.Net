using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    
    
    class Student
    {
        string _studentType = "Full Time";
        string _id = "1234";
        string _fName = "Jeff";
        string _lName = "Wiley";

        public Student(string id)
            : this(id, "", "")
        {

        }

        public Student(string id, string fName)
            : this(id, fName, "")
        {

        }

        public Student(string id, string fName, string lName)
        {
            //Validate logic.....
            _studentType = "<student_type>";

            _id = id;
            _fName = fName;
            _lName = lName;
        }
    }
    
}
