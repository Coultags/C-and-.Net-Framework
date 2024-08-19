using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDB
{

    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Jughead" };

                ctx.Students.Add(stud);
                ctx.SaveChanges();

                Console.WriteLine("Student has been saved successfully!");
                Console.ReadLine();
            }
        }
    }
}

