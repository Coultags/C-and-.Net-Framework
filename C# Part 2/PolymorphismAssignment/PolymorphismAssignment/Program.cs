using System;


namespace PolymorphismAssignment
{
    class Program
    {
        static void Main()
        {
            //Creating a Employee object.
            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "Eric",
                LastName = "Crow"
            };

            //Creating the IQuittable reference and assigning it to the Employee object
            IQuittable quittableEmployee = employee;

            //Calling the Quit Method on the IQuittable reference.
            quittableEmployee.Quit();

            //Displaying the Employee's Information.
            Console.WriteLine($"Employee: {employee.FirstName} {employee.LastName}, ID: {employee.Id}");

            //Keeps the console window open till any key is pressed
            Console.WriteLine("Press any key to exit....");
            Console.ReadKey();
        }
    }
}
