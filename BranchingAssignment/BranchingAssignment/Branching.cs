using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("Please enter package weight");
            Console.ReadLine();

            int weight = 50;
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Please enter the width of the package");
                Console.ReadLine();
            }
            int width = 25;
            
            Console.WriteLine("Please enter the height of the package");
            int height = 12;
            Console.ReadLine();

            Console.WriteLine("Please enter the lengh of the package");
            int lenght = 22;
            Console.ReadLine();
        }

    }
}
