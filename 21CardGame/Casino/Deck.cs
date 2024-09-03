using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    public class Deck
    {
        public Deck() 
        {
            Cards = new List<Card>();
            

            for(int i = 0; i < 13; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.Face = (Face)i;
                    card.Suit = (Suit)j;
                    Cards.Add(card);
                }
            }

        }
        public List<Card> Cards { get; set; }

        // setting a parameter equal to 1, gives it a defualt parameter and allows you to input a argument if needed
        // out parameter goes before all other parameters, it sends varaibles outside the method, rather than returning them
        public void Shuffle(  int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> tempList = new List<Card>();
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    // This is a random number generator between 0 and the total count of cards left in the deck
                    int randomIndex = random.Next(0, Cards.Count);
                    // This will add that randomly selected card to the tempList we created
                    tempList.Add(Cards[randomIndex]);
                    // This will remove that selected card from the main list, and lower the count as well
                    Cards.RemoveAt(randomIndex);

                }
                // we now assign that tempDeck that has the randomly selected cards to the main deck.
                // The main deck is now shuffled
                Cards = tempList;

            }


            
        }
    }
}
