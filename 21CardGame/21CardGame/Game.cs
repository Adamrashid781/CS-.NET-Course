using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21CardGame
{
    public abstract class Game
    {
        public List<Player> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }
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

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }

    }
}
