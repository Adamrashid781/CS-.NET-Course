using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace _21CardGame
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {

            // Line of code below will take the first card of the shuffled deck of cards and add it to the Hand List
            Hand.Add(Deck.Cards.First());
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);
            // This code will log the exact time every card is being dealt in the game and will write it o the Log.txt file
            using (StreamWriter file = new StreamWriter(@"\\Mac\Home\Desktop\Log.txt", true))
            {
                file.WriteLine(DateTime.Now);
                file.WriteLine(card);
            }
            // This line will remove the first item in the Deck list
            Deck.Cards.RemoveAt(0);
        }
    }
}
