using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> num1 = new List<int> { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
            Console.WriteLine("Give a whole number to divivde all the numbers in the list by.");
            try
            {
                int numberInput = Convert.ToInt32(Console.ReadLine());
                foreach (int number in num1)
                {
                    int outPut = number / numberInput;
                    Console.WriteLine(outPut);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();

            //try
            //{
            //    Console.WriteLine("Pick a number.");
            //    int number1 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("deviding list items by given number.");
            //    Console.WriteLine("Deviding the two...");
            //    int number3 = number1 / num1[];
            //    Console.WriteLine(number1 + " devided by " + number2 + " equals " + number3);
            //    Console.ReadLine();
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine("Please type a whole number");
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("Please don't divide by zero.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            Console.ReadLine();
            


        }
    }
}
