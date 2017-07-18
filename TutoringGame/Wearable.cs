// (Wearable) Interface (Tier 3)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    // Wearable Interface
    // Meant to resemble any items that can be worn or equipped
    // And eventually even familiars
    //
    // Implements Item Interface

    interface Wearable: T2Item
    {
        // Every Wearable must implement (Weight, IsWearable)
        int Weight { get; set; }
        bool IsWearable { get; set; }
    }
}
