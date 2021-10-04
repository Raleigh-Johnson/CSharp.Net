using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAndLists
{
    class Program
    {
        public static void Main(string[] args)
        {
           
                 

            
            
            List<Employee> employees = new List<Employee>
            {
                new Employee { FirstName = "Joe", LastName = "Wiley", ID = 0 },
                new Employee { FirstName = "Mikah", LastName = "Anders", ID = 1 },
                new Employee { FirstName = "Eve", LastName = "Wiatt", ID = 2 },
                new Employee { FirstName = "Andrew", LastName = "Sandches", ID = 3 },
                new Employee { FirstName = "Joe", LastName = "Jefferson", ID = 4 },
                new Employee { FirstName = "Zepher", LastName = "Crosby", ID = 5 },
                new Employee { FirstName = "Penelope", LastName = "Jacobs", ID = 6 },
                new Employee { FirstName = "Eric", LastName = "Rodrigues", ID = 7 },
                new Employee { FirstName = "David", LastName = "Amber", ID = 8 },
                new Employee { FirstName = "Sarah", LastName = "Weisbrodt", ID = 9 }
            };

            List<Employee> EmployeeList = employees.FindAll(x => x.FirstName == "Joe");
            Console.WriteLine(employees);
            //foreach (Employee employee in employees )
            //{
            //    Console.WriteLine(employee);
            //}
            Console.ReadLine();










        }


    }
}








