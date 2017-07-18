// (GameObject) Interface (Tier 1)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    // Game Object Interface
    //
    // Parent of all other T-Classes/Interfaces

    interface T1GameObject
    {
        // Every Game Object must implement (Name, Description, IsGameObject)
        String Name { get; set; }
        String Description { get; set; }
        bool IsGameObject { get; set; }

        // A little teaser for a later point
        // There will be abilities that can take away GameObject status to pull
        // crazy moves later in the game
    }
}
