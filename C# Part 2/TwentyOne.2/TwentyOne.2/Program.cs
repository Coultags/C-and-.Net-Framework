using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne._2
{   //Main program welcoming and asking player for their name and how much money they have brought to bet with
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Green Hills Casino. What is your name player?");
            string playerName = Console.ReadLine();
            Console.WriteLine("How much money did you bring with you today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0}. Would you like to play a game of 21?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {   //Starts a game after player as answered to the following question
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing today!");
            } //Returns the following message if the player does not wish to play.
            Console.WriteLine("Feel free to look around the casino. Goodbye for now!");
            Console.Read();
        }
    }
}
