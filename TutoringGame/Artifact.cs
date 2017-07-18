// (Artifact) Class (Tier 4)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    // Artiface Class
    //
    // Implements Enchantment, and Wearable

    public class Artifact : T3Enchantment, Wearable
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
        public bool IsEnchantment { get; set; }
        public int ManaCost { get; set; }

        // Must be implemented from Wearable
        public bool IsWearable { get; set; }
        public int Weight { get; set; }

        // Shows that the Usable Game Object is an Artifact
        public bool IsArtifact { get; set; }

        // Going to have ability-class, value property, and duration as the main
        // 3 stats personalized to Artifacts
        // private Ability{get;set}
        private int amount;
        private int duration;

        public int Amount { get; set; }
        public int Duration { get; set; }
        
    }
}
