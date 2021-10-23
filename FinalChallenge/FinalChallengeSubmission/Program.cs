using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallengeSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            using ( var db = new SchoolContext())
            {
                var student = new Student()
                {
                    StudentName = "Henry Rodgers",
                    EmailAddress = "Raleighj.dev@gmail.com"
                };

                db.Students.Add(student);
                db.SaveChanges();

                var query = from b in db.Students
                            select b;

                foreach (var item in query)
                {
                    Console.WriteLine(item.StudentName);
                }

                Console.ReadLine();
            }
        }
    }
}
