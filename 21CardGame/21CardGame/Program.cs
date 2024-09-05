using System;
using System.IO;

namespace _21CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text";
            //File.WriteAllText(@"\\Mac\Home\Desktop\Log.txt", text);
            // string text = File.ReadAllText(@"\\Mac\Home\Desktop\Log.txt");

            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime YearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGraduation = YearOfGraduation - yearOfBirth;

            //// part of Constructor Chaining
            //Player player2 = new Player("Adam");

            // Creating a Global Unique Identifier
            //Guid identifier = Guid.NewGuid();


            Console.WriteLine("Welcome to the Grand Hotel and Casino. lets start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");

            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("hello, {0}. Would you like to join a game of 21 right now?", playerName);

            string answer = Console.ReadLine().ToLower();
            if(answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                // creting the player object while passing into it the data of the player, their name and how much money they brough with them.
                Player player = new Player(playerName, bank);
                player.Id = Guid.NewGuid();
                // This code will write the users Guid to the file
                using (StreamWriter file = new StreamWriter(@"\\Mac\Home\Desktop\Log.txt", true))
                {
                    file.WriteLine(player.Id);
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;

                while(player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");

            // int count = deck.Cards.Count(x => x.Face == Face.Ace);

            // List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList() ;

            //List<int> numberlist = new List<int>() { 1, 2, 3, 535, 342, 23 };
            //int sum = numberlist.Where(x => x > 20).Sum();


            
            Console.ReadLine();
        }

       
    }

    public enum DaysOfTheWeek { 
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
    }
}
