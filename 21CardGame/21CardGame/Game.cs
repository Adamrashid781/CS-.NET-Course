using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    public abstract class Game
    {
        private List<Player> _players = new List<Player>();
        public List<Player> Players { get { return _players; } set { _players = value; } }
        public string Name { get; set; }

        private Dictionary<Player, int> _bets = new Dictionary<Player, int>();
        public Dictionary<Player, int> Bets { get { return _bets; } set { _bets = value; } }
        
        // If we set a Method to be Abstract it means that every Class that inherits this Class will need to have that Method written
        public abstract void Play();
        // Virtual method inside of an abstract class means that this method gets inherited by another class but has the ability to be overridden 
        public virtual void ListPlayers()
        {
            foreach(Player player in Players)
            {
                Console.WriteLine(player.Name);
            }
        }

    }
}
