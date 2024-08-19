using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.cs
{
    class StudentContext : DbContext
    {
        public SchoolContext() : base()
        {

        }

        public Dbset<Student> Students { get; set; }
        public Dbset<Grade> Grades { get; set; }
    }
}
