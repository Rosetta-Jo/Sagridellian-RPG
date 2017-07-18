// (Prayer) Class (Tier 4)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    // Prayer Class
    //
    // Implements Enchantment Interface

    public class Prayer : T3Enchantment
    {
        // Must be implemented from Game Object
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsGameObject { get; set; }

        // Must be implemented from Item
        public bool IsItem { get; set; }
        public int Index { get; set; }
        public int Cost { get; set; }

        // Must be implemented from Enchantment
        public int ManaCost { get; set; }
        public bool IsEnchantment { get; set; }

        // Unique to prayers
        private String alignment;
        private int faithRequired;
        private int charityRequired;

        public string Alignment { get; set; }
        public int FaithRequired { get; set; }
        public int CharityRequired { get; set; }

        // Shows that the Usable Game Object is a prayer
        public bool IsPrayer { get; set; }
    }
}
