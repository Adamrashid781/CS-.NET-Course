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



            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jesse", "Adam", "Joe" };
            game.ListPlayers();
            game.Play();
            Console.ReadLine();
            game.Dealer = "Jesse";
            game.Name = "TwentyOne";


            //// Creating a object of data type Deck
            //Deck deck = new Deck();
            
            
            //deck.Shuffle( 5);
            //// you can put named perameters
            //// deck = Shuffle(deck: deck, times: 5);


            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);

            



            Console.ReadLine();
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
