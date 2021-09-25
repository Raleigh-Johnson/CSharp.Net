using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statments
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());

            bool isGuessed = false; // will not be true until user guess 12

            while (!isGuessed) //(While "isGuessed" is false, Run this loop.
            switch (number)
            {
                case 62:
                    Console.WriteLine("You guessed 62. Aweful choise."); //Special answers 
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                case 29:
                    Console.WriteLine("You guessed 29. Really?");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                case 13:
                    Console.WriteLine("You guessed 13. Personally, my least favorite number.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                case 12:
                    Console.WriteLine("You guessed 12. That is correct! Great Job!"); //Correct Answer, but completely subjective 
                        isGuessed = true;
                    break;

                default:
                    Console.WriteLine("You are wrong. Dum dum."); //Default answer, all not specified answers default to this.
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    



            }
            Console.ReadLine(); //Stops code so User can read. 
        }
    }
}
