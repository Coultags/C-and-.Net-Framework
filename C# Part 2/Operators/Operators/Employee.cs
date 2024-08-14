using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Employee


    {
        //Creates an Employee class with Id, FirstName, and LastName Properties.
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }

        public Employee(int id, string fn, string ln)
        {
            Id = id;
            FirstName = fn;
            LastName = ln;
        }

        //The comparison operators must be overloaded in pairs.

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            return employee1.Id == employee2.Id;
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return employee1.Id != employee2.Id;
        }
        public override bool Equals(object obj)
        {
            return obj is Employee employee;
        }
    }
}
