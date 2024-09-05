using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    public class Player
    {
        // Constructor Chaining: This first constructor will always hit first if the player does not add a balance. 
        // The player will pass their name when creating the constructor as refereenced in the Program, if they do not pass a int value
        // the first constructor will pass the value of 100 to the second, chained constructor, and this will take both values and assign them
        public Player(string name) : this(name, 100) 
        { 
        }
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

        public Guid Id { get; set; }
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
