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
           
                 

            
            
            List<Employee> employees = new List<Employee> //Defines Employee List
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
            }; //Filling out Employee List
            List<Employee> JoeEmp = new List<Employee>(); //Defines Employee "Joe" List
               




            //Console.WriteLine(employees);
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    Console.WriteLine(employee.FirstName + " " + employee.LastName + " " + "ID: " + employee.ID);
                    JoeEmp.Add(employee);
                }
            }

            foreach (Employee employee in JoeEmp)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);

            }


            //List<Employee> JoeEmp1 = new List<Employee>(); //Defines Employee Empty "Joe" List for Lambda Expression

            List<Employee> EmployeeJoe = employees.Where(x => x.FirstName == "Joe").ToList();

            foreach (Employee employee in EmployeeJoe)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            List<Employee> LambdaEmp = employees.Where(x => x.ID > 5).ToList();
            foreach (Employee employee in LambdaEmp)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            Console.ReadLine();










        }


    }
}








