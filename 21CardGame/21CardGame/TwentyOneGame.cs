using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
   public  class TwentyOneGame : Game, IWalkAway 
    {
        public TwentyOneDealer Dealer { get; set; }
        // Must use the override keyword when using an abstarct class
        public override void Play()
        {
            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();

            Console.WriteLine("Place your bet!");
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 players");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException(); 

        }
    }
}
