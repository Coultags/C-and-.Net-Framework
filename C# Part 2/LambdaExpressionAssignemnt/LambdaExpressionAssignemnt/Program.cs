
using System;
using System.Collections.Generic;
using System.Linq;


namespace LambdaExpressionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Created a list of 10 employees with having two employees with the same first name
            List<Employee> campus = new List<Employee>()
           {
               new Employee() {Id= 1, firstName = "Joe", lastName = "Jones"},
               new Employee() {Id= 2, firstName = "Joe", lastName = "Bones"},
               new Employee() {Id= 3, firstName = "Tom", lastName = "Hardy"},
               new Employee() {Id= 4, firstName = "David", lastName = "Hayes"},
               new Employee() {Id= 5, firstName = "Adam", lastName = "James"},
               new Employee() {Id= 6, firstName = "Dave", lastName = "Stevens"},
               new Employee() {Id= 7, firstName = "MJ", lastName = "Buddy"},
               new Employee() {Id= 8, firstName = "Cole", lastName = "Smtih"},
               new Employee() {Id= 9, firstName = "Lucas", lastName = "Frank"},
               new Employee() {Id= 10, firstName = "Jim", lastName = "Barkley"}
           };

            //Used a foreach loop, to create a new list of all employees with the first name of "Joe"
            List<Employee> joes = new List<Employee>();
            foreach (Employee employee in campus)
            {
                if (employee.firstName == "Joe")
                {
                    joes.Add(employee);
                }
            }
            //Added the lambda expression to create the list
            List<Employee> joes2 = campus.Where(x => x.firstName == "Joe").ToList();
            //This Lambda Expression is making a list of employees whos ID is number is greater then 5
            List<Employee> bigId = campus.Where(x => x.Id > 5).ToList();
            Console.ReadLine();
        }
    }
}
