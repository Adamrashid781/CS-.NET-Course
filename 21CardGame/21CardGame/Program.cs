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

            Game game = new TwentyOneGame();
            game.Players = new List<Player>(); 
            Player player = new Player();
            Player player1 = new Player();
            player0.Name = "Zuzu";
            player1.Name = "Adam";
            game = game + player0;
            game = game + player1;
            game = game - player0; 
            // Creating a object of data type Deck
            Deck deck = new Deck();


            deck.Shuffle(5);
            // you can put named perameters
            // deck = Shuffle(deck: deck, times: 5);


            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);





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
