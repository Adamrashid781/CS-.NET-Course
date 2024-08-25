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
            Deck deck = new Deck();

            // int count = deck.Cards.Count(x => x.Face == Face.Ace);

            // List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList() ;

            //foreach(Card card in newList)
            //{
            //    Console.WriteLine(card.Face);
            //}

            List<int> numberlist = new List<int>() { 1, 2, 3, 535, 342, 23 };
            int sum = numberlist.Where(x => x > 20).Sum();

            Console.WriteLine(sum);
            

            //// Creating a object of data type Deck
            //Deck deck = new Deck();
            //deck.Shuffle(5);
            //// you can put named perameters
            //// deck = Shuffle(deck: deck, times: 5);


            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
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
