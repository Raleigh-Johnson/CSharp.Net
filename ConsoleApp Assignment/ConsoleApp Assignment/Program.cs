using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Jeff", "Wiley", "Raleigh", "Tulsa" }; //Variables 
            List<string> food = new List<string> { "Pickles", "Pickles", "Spaghetti", "Apples", "Broccoli", "Avocado" };
            List<string> check = new List<string> { };

            int iteration = 0;


            //ConsoleApp 3
            //while (iteration <= 1) //While iteration is below or equal to 3
            //{
            //    Console.WriteLine("Hello. Input a string to be added to the array.");
            //    string newName = Console.ReadLine();

            //    foreach (string name in names)
            //    {
            //        string addName = (name + newName);
            //        Console.WriteLine(addName);
            //    }
            //    iteration++;
            //    Console.WriteLine("Iteration" + (iteration));
            //    Console.ReadLine();
            //    if (iteration == 1);
            //    {
            //        Console.WriteLine("Thank you for submitting.");
            //    }

            //}
            //ConsoleApp 4 
            //Console.WriteLine("Input search term"); 
            //string search = Console.ReadLine();
            //bool inList = false;
            //for (int i = 0; i < names.Length; i++)
            //{
            //    if (search == names[i])
            //    {
            //        Console.WriteLine("The matching index of " + search +" is " + i);
            //        inList = true;
            //    }

            //}
            //if (inList == false)
            // {
            //    Console.WriteLine("Sorry, The term " + search + " was not found.");
            //}
            //Console.ReadLine();



            //ConsoleApp 5

            //Console.WriteLine("Input search term");
            //string search = Console.ReadLine();
            //bool inList = false;
            //for (int i = 0; i < food.Length; i++)
            //{
            //    if (search == food[i])
            //    {
            //        Console.WriteLine("The matching index of " + search + " is " + i);
            //        inList = true;
            //    }

            //}
            //if (inList == false)
            //{
            //    Console.WriteLine("Sorry, The term " + search + " was not found.");
            //}
            //Console.ReadLine();

            //ConsoleApp 6

            
            foreach (string foods in food)
            {
                bool inList = false;
                Console.WriteLine(foods);
               

                foreach (string checking in check)
                {
                    if (foods == checking)
                    {
                        inList = true;
                    }

                }

                check.Add(foods);

                if (inList == true)
                {

                    Console.WriteLine(foods +" is already in the list.");

                }

                else
                {
                    Console.WriteLine(foods + " is not in the list.");
                }

            }
            Console.ReadLine();




            //{


            //        Console.WriteLine("The matching index of " + search + " is " + );
            //        inList = true;


            //}
            //if (inList == false)
            //{
            //    Console.WriteLine("Sorry, The term " + search + " was not found.");
            //}
            Console.ReadLine();



        }
    }
}
