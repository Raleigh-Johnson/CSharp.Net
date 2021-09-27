using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {


            //int[] numArray0 = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };
            string[] stringArray = { "Hello", "World", "PeanutButter","Cheezits","Cereal" };
            int[] numArray = { 5, 2, 10, 200, 5000, 600, 2300 };
            List<string> List1 = new List<string>();
            List1.Add("This is a list.");
            List1.Add("Woah Congrats, you chose 1");
            List1.Add("2 is a bad number");
            List1.Add("Shrimp Fried Rice");
            List1.Add("Another day, another dollar");





            Console.WriteLine("Pick a number between 0 and 6"); 
            int Choice1 = Convert.ToInt32(Console.ReadLine());
            if (Choice1 > 6) //Checks to see if user input is a valid array option
            {
                Console.WriteLine("Sorry, Please restart program and enter a valid option.");
                Console.WriteLine();
            }
            Console.WriteLine(numArray[Choice1]); //Displays User's selection


            Console.WriteLine("Pick a number between 0 and 4");
            int Choice2 = Convert.ToInt32(Console.ReadLine());
            if (Choice2 > 4) //Checks to see if users input is greater than total array count
            {
                Console.WriteLine("Sorry, Please restart program and enter a valid option.");
                Console.WriteLine();

            }
            Console.WriteLine(stringArray[Choice2]); //Displays Array chosen by user.

            Console.WriteLine("Pick a number between 0 and 4");
            int Choice3 = Convert.ToInt32(Console.ReadLine());
            if (Choice3 > 4) //Checks to see if users input is greater than total array count
            {
                Console.WriteLine("Sorry, Please restart program and enter a valid option.");
                Console.WriteLine();

            }
            Console.WriteLine(List1[Choice3]); //Displays Array chosen by user.


            Console.ReadLine();

        }
    }
}
