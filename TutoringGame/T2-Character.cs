// (Character) Abstract Class --- parent to - boss - enemy - player (Tier 2)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    // Abstract Character Class
    //
    // Implements Game Object Interface

    abstract public class T2Character : T1GameObject
    {
        // Every Game Object must implement (Name, Description, IsGameObject)
        abstract public String Name { get; set; }
        abstract public String Description { get; set; }
        abstract public bool IsGameObject { get; set; }

        // Every Character must implement (Health, Attack, Defense, Speed)
        abstract public int Health { get; set; }
        abstract public int Attack { get; set; }
        abstract public int Defense { get; set; }
        abstract public int Speed { get; set; }

        // Placeholder for Methods that may come soon...
        abstract public void Reset();
    }
}
