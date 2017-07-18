// (Armor) Class (Tier 4)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    // Armor Class
    //
    // Implements Wearable

    public class Armor : Wearable
    {
        // Must be implemented from Game Object
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsGameObject { get; set; }

        // Must be implemented from Item
        public bool IsItem { get; set; }
        public int Index { get; set; }
        public int Cost { get; set; }

        // Must be implemented from Wearable
        public bool IsWearable { get; set; }
        public int Weight { get; set; }

        // Unique to Armor
        private int toughness;
        private String smithyName;
        private int shielding;
        private String ore;

        public int Toughness { get; set; }
        public String SmithyName { get; set; }
        public int Shielding { get; set; }
        public String Ore { get; set; }

        // Shows that the Usable Game Object is a piece of armor
        public bool IsArmor { get; set; }
    }
}
