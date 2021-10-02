using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class VoidClass
    {
        public void Operation(int userInput1)//"Operation" name of method
        {
            int answer1 = userInput1 / 2;//Devides userInput1 by 2
            Console.WriteLine(answer1);
        }

        public void Operation(decimal x) //Takes in a decimal
        {
            decimal answer1 = x + 5;
            Console.WriteLine(answer1);
        }
        public void Operation(decimal x, decimal y)
        {
            decimal answer2 = x + y;
            Console.WriteLine(answer2);
        }
        public void Operation1(out decimal z)
        {
            z = 13;
            Console.WriteLine(z);
        }
    }
}
