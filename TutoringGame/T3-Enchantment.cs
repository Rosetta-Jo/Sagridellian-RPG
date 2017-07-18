// (Enchantment) Interface (Tier 3)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    // Enchantment Interface
    // Meant to hold the spells, and abilities that can be
    // at times tagged onto an item or other gear
    //
    // Implements Item Interface

    interface T3Enchantment : T2Item
    {
        // Every Wearable must implement (ManaCost, IsEnchantment)
        int ManaCost { get; set; }
        bool IsEnchantment { get; set; }
    }
}
