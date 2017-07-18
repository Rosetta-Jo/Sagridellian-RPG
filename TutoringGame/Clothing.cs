// (Clothing) Class (Tier 4)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    // Clothing Class
    //
    // Implements Wearable Interface

    public class Clothing : Wearable
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

        // Unique to Clothing
        private String material;
        private String designerName;
        private int popularity;

        public string Material { get; set; }
        public String DesignerName { get; set; }
        public int Popularity { get; set; }

        // Shows that the Usable Game Object is a piece of clothing
        public bool IsClothing { get; set; }
    }
}
