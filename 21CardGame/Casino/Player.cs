using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    public class Player
    {
        public Player(String name, int begginingBBalance)
        {
            Hand = new List<Card>();
            Balance = begginingBBalance;
            Name = name;
        }
        private List<Card> _hand = new List<Card>(); 
        public List<Card> Hand { get { return _hand; } set {  _hand = value;  } }
        public int Balance { get; set; }
        public string Name { get; set; }
        public bool isActivelyPlaying { get; set; }

        public bool Stay { get; set; }

        public bool Bet(int amount)
        {
            if(Balance - amount < 0)
            {
                Console.WriteLine("You do not have enough money to place this bet!");
                return false;
            }
            else
            {
                Balance -= amount;
                return true; 
            }

        }

        // Overloading Operators
        public static Game operator+ (Game game, Player player)
        {
            game.Players.Add(player);
            return game;
        }

        public static Game operator- (Game game, Player player)
        {
            game.Players.Remove(player);
            return game;
        }
    }

    public struct Number
    {
        public decimal Amount { get; set; }

    }

}
