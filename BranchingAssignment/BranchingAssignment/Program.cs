using System;

namespace BranchingAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
           

            Console.WriteLine("Welcome to Package Express. Please follow the instructions below\n" + "\nPlease enter the weight of your package"); //Start of the program
            int weight = Convert.ToInt32(Console.ReadLine());  //User enter package weight and will either tell them to heavy to ship. If package is under 50 than it will ask for the next three items
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
              
            }
            else
            {
                Console.WriteLine("Please enter the width of the package");
                int width = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the height of the package");
                int height = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter the lengh of the package");
                int lenght = Convert.ToInt32(Console.ReadLine());                   
                          
                int Sum = Convert.ToInt32(width) + Convert.ToInt32(height) + Convert.ToInt32(lenght);  //After user has put in desire values it will add them together and get a total for the package
                if (Sum > 50)
                {
                    Console.WriteLine("Package is too big to be shipped out via Package Express"); //if the sum is greater then 50 it wll display the following error
                    Console.ReadLine();
                }
                else
                {
                    double cost = (Convert.ToDouble(width) * Convert.ToDouble(height) * Convert.ToDouble(lenght) * Convert.ToDouble(weight)) / 100; //Adds a float number to the display and multiples everything together to get the package total size amd price
                    Console.WriteLine("Your estimated total to ship your package is: \n\n" + "$"+ cost + "\n\nThank you for choosing Package Express"); //Display the final shipping cost and messaging regaurding the package
                    Console.ReadLine();
                }
            }
  
        }

    }
}
