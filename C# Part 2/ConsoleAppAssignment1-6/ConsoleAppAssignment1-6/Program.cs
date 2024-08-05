using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppAssignment1_6
{
    class Program
    {
        private static object responses;

        static void Main(string[] args)
        {
            //Part 1 of 6
            //Dimensional Array of Strings
            String[] wordstart =
            {
                "Welcome to the new ",
                "I am your teacher for the year, ",
                "My goal is to help each of you pass this class and provide "
            };
            string[] wordend =
            {
                " school year. ",
                ",",
                "the best learning experince as possible."
            };
            List<string> reponses = new List<string>();
            //Asks the user of the program to input some text
            Console.WriteLine("Please enter a noun:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Please enter the name of someone who is infamous:");
            responses.Add(Console.ReadLine());
            Console.WriteLine("Please enter a adjective");
            responses.Add(Console.ReadLine());
            //Creating a loop that goes through each string in the array, and adds the user's text to the string.
            for (int i = 0; i < wordstart.Length; i++)
            {
                wordstart[i] += responses[i];
                Console.WriteLine(wordstart[i] + wordend[i]);
            }
            Console.ReadLine();
            Console.WriteLine("The strings that we used:");
            //Crating a loop that prints off each string in the Array on a separate line
            for (int i = 0; i < wordstart.Length; i++)
            {
                Console.WriteLine(wordstart[i] + wordend[i]);
                //Part 2 
                //Creating an infinite loop (uncomment "i--" for the infinite loop.
                //Fix the infinite loop
                //i--;
            }
            Console.ReadLine();

            //Part 3
            Console.WriteLine("Is there someone in here?!");
            StringBuilder boo = new StringBuilder();
            boo.Append("B");
            //Creating a loop where the comparison that is used to determine whether to continue the loop is a "<" operator.
            while (boo.Length < 10)
            {
                boo.Append("o");
            }
            boo.Append("!");
            Console.ReadLine();
            Console.WriteLine(boo);
            Console.ReadLine();
            StringBuilder ahh = new StringBuilder();
            ahh.Append("A");
            //Add a loop where the comparsion that's used to determine whether to continue the loop is a "<=" operator.
            while (ahh.Length <= 10)
            {
                ahh.Append("h");
            }
            ahh.Append("!");
            Console.WriteLine(ahh);
            Console.ReadLine();

            //Part 4 
            //Creating a List of strings where each item in the list is unique.
            List<string> teams = new List<string>() { "Oilers", "Flames", "Canucks", "Kraken", "Sharks", "Golden Knights", "Kings", "Ducks" };
            Console.WriteLine("NHL Pacific Standings");
            //Asking the user to enter a team name
            Console.WriteLine("Enter team name:");
            int standing = 0;
            bool isValid = false;
            int index = 0;
            //Creates a loop that iterates through the list and then displays the index of the array that contains matching text on the screen.
            while (!isValid)
            {
                int i2 = 0;
                string teamrequest = Console.ReadLine();
                foreach (string team in teams)
                {
                    if (teamrequest == team)
                    {
                        standing = i2 + 1;
                        index = i2;
                    }
                    i2++;
                }
                //Add code to that above loop that tells a user if they put in text that isn't in the list.
                if (standing == 0)
                {
                    Console.WriteLine("THis is not a valid team name. Enter again:");
                }
                //Add code that above loop that stops it from executing once a match has been made.
                else
                {
                    isValid = true;
                }
            }
            Console.WriteLine("Processing... Index is: " + index + ". So....");
            Console.WriteLine("Standing is: " + standing);
            Console.ReadLine();

            //Part 5 
            //Creating a List of strings that share at least two indentical strings in a List.
            List<string> tables = new List<string>() { "Reserved", "Vacant", "Taken", "Vacant", "Vacant", "Reserved", "Taken" };
            Console.WriteLine("Welcome to del taco! \nDue to Covid-19 we have a mobile check in. \nIf you need a reservation type " + "\"Resevred\".\n If you are joining a party here type \"Taken\".\nOtherwise type \"Vacant\".");
            //Asks the users to select text to search for in the list
            Console.WriteLine("Enter Selection:");
            string selection = Console.ReadLine();
            while (!(selection == "Vacant" || selection == "Reserved" || selection == "Taken"))
            {
                //Adds code to tell the user if they enter text that isn't on the List.
                Console.WriteLine("Please enter one of the 3 choices:");
                selection = Console.ReadLine();
            }
            Console.WriteLine("The table that match your selection are numbered:");
            //Creates a loop that iterates through the loop then displays the indices of the array that contain matching text on the screen
            for (int i3 = 0; i3 < tables.Count; i3++)
            {
                if (selection == tables[i3])
                {
                    Console.WriteLine(i3);
                }
            }
            Console.ReadLine();

            //Part 6
            //Create a List that has at least two identical strings in the List.
            List<string> names = new List<string>() { "Bob", "Jim", "Tiffany", "Bob", "Josh", "Tim", "Kim", "Kim" };
            List<string> repeatCheck = new List<string>();
            Console.WriteLine("Employee Rooster:");
            //Creates a foreach loop that evulations each item in the list, displaying a message showing the string and whether it is already on the list or not.
            foreach (string name in names)
            {
                Console.WriteLine(name);
                if (repeatCheck.Contains(name))
                {
                    Console.WriteLine("This name has been repeated. \nUse the last name initial when referring to this employee.");
                }
                else
                {
                    Console.WriteLine("This name has not been repeated.");
                }
                repeatCheck.Add(name);
            }
            Console.ReadLine();
        }
    }
}
