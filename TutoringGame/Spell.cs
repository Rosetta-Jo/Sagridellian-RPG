// (Spell) Class (Tier 4)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    // Spell Class
    //
    // Implements Enchantment Interface

    public class Spell : T3Enchantment
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

        // Unique to Spells
        private string family;
        private int knowledgeRequired;
        private int practiceRequired;

        public string Family { get; set; }
        public int KnowledgeRequired { get; set; }
        public int PracticeRequired { get; set; }

        // Shows that the Usable Game Object is a spell
        public bool IsSpell { get; set; }
    }
}
