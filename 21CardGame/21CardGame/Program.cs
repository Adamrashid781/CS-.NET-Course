using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    class Program
    {
        static void Main(string[] args)
        {

            // Creating a object of datatype Card

            //Card cardOne = new Card();

            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            //Console.ReadLine();

            //Card cardTwo = new Card();

            //Console.WriteLine(cardTwo.Face + " of " + cardTwo.Suit);



            // Creating a object of data type Deck

            Deck deck = new Deck();
            // deck = Shuffle(deck);
            int timesShuffled = 0;
            deck = Shuffle(deck, out timesShuffled, 5);
            // you can put named perameters
            // deck = Shuffle(deck: deck, times: 5);


            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);

            Console.WriteLine("Times Shuffled: {0}", timesShuffled);



            Console.ReadLine();
        }
        // setting a parameter equal to 1, gives it a defualt parameter and allows you to input a argument if needed
        // out parameter goes before all other parameters
        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                List<Card> tempList = new List<Card>();
                Random random = new Random();
            
                while (deck.Cards.Count > 0)
                {
                    // This is a random number generator between 0 and the total count of cards left in the deck
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    // This will add that randomly selected card to the tempList we created
                    tempList.Add(deck.Cards[randomIndex]);
                    // This will remove that selected card from the main list, and lower the count as well
                    deck.Cards.RemoveAt(randomIndex);

                }
                // we now assign that tempDeck that has the randomly selected cards to the main deck.
                // The main deck is now shuffled
                deck.Cards = tempList;
                timesShuffled++;
                
            }
            

            return deck;
        }
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for(int i = 0; i < times; i++)
        //    {
        //        deck = Shuffle(deck);

        //    }
        //    return deck;
        //}
    }
}
