using System;
using System.Collections.Generic;


namespace ConsoleArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Setting up an array
            string[] colorArray = { "Red", "Blue", "Green", "White", "Orange", "Indigo", "Voilet", "Black", "Brown", "Yellow" };
            //Asking the user for a number to display the string from the index
            Console.WriteLine("Select a number between 0 and 9:");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool vaildString = false;

            while (!vaildString)
            {
                try
                {
                    Console.WriteLine("Your favorite color is " + colorArray[stringSelect]);
                    vaildString = true;
                }
                //Message to display if the user picks an index that doesn't not exist
                catch
                {
                    Console.WriteLine("Sorry, number selected does not exist. Please pick a number between 0 and 9. ");
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        //Doing a list of Strings
        List<string> occupationList = new List<string>()
        { "Software Devopler",
          "Banker",
          "Cashier",
          "Stock Personal",
          "Teacher",
          "Streamer",
          "Blogger",
          "Cop",
          "Lawyer",
          "Game Designer"
        };

        //Ask the user to display the string at the index
        Console.WriteLine("\nSelect antoher number between 0 and 9:");
        int listSelect = Convert.ToInt32(Console.ReadLine());
        bool validList = false;
            
          while (!validList)
          {
               try
               {
                    Console.WriteLine("Your new occupation is: " + occupationList[listSelect]);
                    validList = true;
               }

                // Adding another message to display if the user picks an index that doesn't exist
                catch
                {
                    Console.WriteLine("Sorry, That number is invalid. Please pick a number 0 and 9. );
                    listSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
                
                //Array of intergers
                int[] intArray = { 25, 35, 6, 13, 49, 61, 2, 91, 96, 4 };
                Console.WriteLine("\nSelect a third number between 0 and 9:");
                int listSelect = Convert.ToInt32(Console.ReadLine());
                bool validList = false;

                while (!validList)
                {
                    try
                    {
                        Console.WriteLine("Your lucky number is: " + intArray[listSelect]);
                         validList = true;
                    }

                    // Adding another message to display if the user picks an index that doesn't exist
                    catch
                    {
                         Console.WriteLine("Sorry, That number is invalid. Please pick a number 0 and 9. );

                         listSelect = Convert.ToInt32(Console.ReadLine());
    }
}
