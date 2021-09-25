using System;


namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you?");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? true/false");
            bool dui = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("How many speeding tickets do you have??");
            int tickets = Convert.ToInt32(Console.ReadLine());
            bool qualified = (age > 15 && dui != true && tickets <= 3);
            Console.WriteLine("Are you qualified to drive?");
            Console.WriteLine(qualified);
                
            Console.ReadLine();
        }
    }
}
