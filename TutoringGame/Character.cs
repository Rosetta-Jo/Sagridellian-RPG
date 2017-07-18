// (Character) Abstract Class - parent of boss, enemy, player

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    // Abstract Character Class
    abstract public class Character
    {
        // Properties shared by Boss, Enemy, Player
        abstract public int Health { get; set; }
        abstract public int Attack { get; set; }
        abstract public int Defense { get; set; }
        abstract public int Speed { get; set; }
        abstract public String Name { get; set; }
        abstract public String Description { get; set; }

        // Placeholder for Methods that may come soon...
        abstract public void Reset();
    }
}
