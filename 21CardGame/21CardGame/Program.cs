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
            deck = Shuffle(deck);
            
            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);

            

            

            Console.ReadLine();
        }

        public static Deck Shuffle(Deck deck)
        {
            List<Card> tempList = new List<Card>();
            Random random = new Random();

            while(deck.Cards.Count > 0)
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

            return deck;
        }
    }
}
