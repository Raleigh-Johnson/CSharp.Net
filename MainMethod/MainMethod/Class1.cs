using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Class1
    {
        public int Operation1(int number1)
        {
            int answer1 = number1 * 5; //Operator for answer1
            return answer1;
        }

        public decimal Operation1(decimal number1)
        {
            decimal answer2 = number1 * 5;
            int number2 = Convert.ToInt32(answer2);//Converts from decimal to integer to be returned
            return answer2;
        }

        public int Operation1(string number1)
        {
            int number3 = Convert.ToInt32(number1);//Converts string to integer
            int answer3 = number3 * 5;
            return answer3;
        }
    }
}
