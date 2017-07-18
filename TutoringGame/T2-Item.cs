// (Item) Interface (Tier 2)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    // Item Interface implements GameObject Interface
    // Item is the broadest category of GameObjects that are used by the other half
    // of the GameObjects family
    //
    // Implements Game Object Interface

    interface T2Item : T1GameObject
    {
        // Every Item must implement (Index, Cost, IsItem)
        int Index { get; set; }
        int Cost { get; set; }
        bool IsItem { get; set; }
    }
}
