using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program 
    {
        public enum DaysOfTheWeek
        {
            Monday,     //0
            Tuesday,    //1
            Wednesday,  //2
            Thursday,   //3
            Friday,     //4
            Saturday,   //5
            Sunday      //6
        }


        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a day of the week."); //Asks User for input 
                string Day = Console.ReadLine();
                DaysOfTheWeek DayOfWeek = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Day); //User input for "DayOfWeek"
                Console.WriteLine("You chose: " + DayOfWeek);
            }

            catch
            {
                Console.WriteLine("Please enter a valid day of the week."); //Catch block for if the user submits a non-valid input

            }

            Console.ReadLine();
        }


           


        
    }
}
