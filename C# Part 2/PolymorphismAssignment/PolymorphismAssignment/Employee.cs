using System;

namespace PolymorphismAssignment
{
    public class Employee : IQuittable
    {
        //Employee ID.
        public int Id { get; set; }

        //Employee's First Name
        public string FirstName { get; set; }

        //Employee's Last Name
        public string LastName { get; set; }

        //Overlord the == operator to compare two Employee objects by their ID
        public static bool operator ==(Employee e1, Employee e2)
        {
            if (ReferenceEquals(e1, e2))
                return true;

            if (e1 is null || e2 is null)
                return false;

            return e1.Id == e2.Id;
        }

        //overload the != operator
        public static bool operator !=(Employee e1, Employee e2)
        {
            return !(e1 == e2);
        }

        //overload Equals to use the custom == operator for comparison
        public override bool Equals(object obj)
        {
            if (obj is Employee employee)
            {
                return this == employee;
            }
            return false;
        }

        //override the GetHashCode to be consistent with the Equals
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        //Implementing the Quit Method from the IQuittible interface
        public void Quit()
        {
            //Prints a message about the indicating employee is quitting
            Console.WriteLine($"{FirstName} {LastName} is quitting");
        }
    }
}
