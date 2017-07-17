using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    public class Item
    {
        /** Identify the Variables */
        private String name;
        private String stat;
        private int value;
        private String itemdescription;

        /** Properties for the Variables */
        public String Name { get; set; }
        public String Stat { get; set; }
        public int Value { get; set; }
        public String Itemdescription;
        
        /** No-Arg Constructor */
        public Item()
        {
            Name = "Health Pot";
            Stat = "HEALTH";
            Value = 3;
            Itemdescription = "A simple potion to recover some lifepoints (3).";
        }
        
        /** Player-Defined Constructor */
        public Item(String name, String stat, int value, String itemdescription)
        {
            Name = name;
            Stat = stat;
            Value = value;
            Itemdescription = itemdescription;
        }

        /** Story-Defined Constructor */
        public Item(String name)
        {
            switch (name)
            {
                case "1":
                    Name = "Health Pot";
                    Stat = "HEALTH";
                    Value = 1;
                    Itemdescription = "A simple potion to recover some lifepoints (1).";
                    break;
                case "2":
                    Name = "Health Pot";
                    Stat = "HEALTH";
                    Value = 2;
                    Itemdescription = "A simple potion to recover some lifepoints (2).";
                    break;
                case "3":
                    Name = "Health Pot";
                    Stat = "HEALTH";
                    Value = 3;
                    Itemdescription = "A simple potion to recover some lifepoints (3).";
                    break;
                case "4":
                    Name = "Attack Pot";
                    Stat = "ATTACK";
                    Value = 1;
                    Itemdescription = "A simple potion to boost attack (1).";
                    break;
                case "5":
                    Name = "Attack Pot";
                    Stat = "ATTACK";
                    Value = 2;
                    Itemdescription = "A simple potion to boost attack (2).";
                    break;
                case "6":
                    Name = "Attack Pot";
                    Stat = "ATTACK";
                    Value = 3;
                    Itemdescription = "A simple potion to boost attack (3).";
                    break;
                case "7":
                    Name = "Defense Pot";
                    Stat = "DEFENSE";
                    Value = 1;
                    Itemdescription = "A simple potion to boost defense(1).";
                    break;
                case "8":
                    Name = "Defense Pot";
                    Stat = "DEFENSE";
                    Value = 2;
                    Itemdescription = "A simple potion to boost defense (2).";
                    break;
                case "9":
                    Name = "Defense Pot";
                    Stat = "DEFENSE";
                    Value = 3;
                    Itemdescription = "A simple potion to boost defense (3).";
                    break;
                case "10":
                    Name = "Speed Pot";
                    Stat = "SPEED";
                    Value = 1;
                    Itemdescription = "A simple potion to boost speed (1).";
                    break;
                case "11":
                    Name = "Speed Pot";
                    Stat = "SPEED";
                    Value = 2;
                    Itemdescription = "A simple potion to boost speed (2).";
                    break;
                case "12":
                    Name = "Speed Pot";
                    Stat = "SPEED";
                    Value = 3;
                    Itemdescription = "A simple potion to boost speed (3).";
                    break;
                case "13":
                    Name = "Mega Pot";
                    Stat = "ALL";
                    Value = 5;
                    Itemdescription = "An overall boosting potion for each stats (5).";
                    break;
            }
        }

    }
}
