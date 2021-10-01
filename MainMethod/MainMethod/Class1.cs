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
            int answer1 = number1 * 5;
            return answer1;
        }

        public decimal Operation2(decimal number1)
        {
            decimal answer2 = number1 * 5;
            int number2 = Convert.ToInt32(answer2);
            return answer2;
        }

        public int Operation3(string number1)
        {
            int number3 = Convert.ToInt32(number1);
            int answer3 = number3 * 5;
            return answer3;
        }
    }
}
