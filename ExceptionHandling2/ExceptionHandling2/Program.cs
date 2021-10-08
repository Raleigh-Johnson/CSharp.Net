using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime DT1 = DateTime.Now;
            Console.WriteLine("Please enter your age.");
            try
            {
                int Age = int.Parse(Console.ReadLine());// assigns the users input to "Age"
                Age *= -1; //Convert user input to a negative to subtract from the current year.
                DateTime UserYrBrn = DT1.AddYears(Age);
                Console.WriteLine("You were born in the year ", UserYrBrn);
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Sorry, please enter a valid integer.");
                Console.ReadLine();
                return;
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please enter a positive Integer.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("Something went wrong, try rebooting and using a different answer.");
                Console.ReadLine();
                return;
            }
           




        }
    }
}

