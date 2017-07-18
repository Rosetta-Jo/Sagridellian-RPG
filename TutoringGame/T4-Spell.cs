// (Spell) Class (Tier 4)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    /* Spell Class
     * 
     * Implements Enchantment Interface
     * 
     */

    public class Spell : T3Enchantment
    {
        /** Must be implemented from Game Object */
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsGameObject { get; set; }

        /** Must be implemented from Item */
        public bool IsItem { get; set; }
        public int Index { get; set; }
        public int Cost { get; set; }

        /** Must be implemented from Enchantment */
        public int ManaCost { get; set; }
        public bool IsEnchantment { get; set; }

        /** Variables */
        private string family;
        private int knowledgeRequired;
        private int practiceRequired;

        /** Properties */
        public string Family { get; set; }
        public int KnowledgeRequired { get; set; }
        public int PracticeRequired { get; set; }

        /** Verifier */
        public bool IsSpell { get; set; }

        /** No-Arg Constructor */
        public Spell()
        {
            // Satisfy Game Object Requirements
            Name = "Spell";
            Description = "A Wizard threw caution to the wind to make this one...";
            IsGameObject = true;

            // Satisfy Item Requirements
            Index = 0;
            Cost = 42;
            IsItem = true;

            // Satisfy Enchantment Requirements
            ManaCost = 1;
            IsEnchantment = true;

            // Set the Properties of the Actual Spell
            Family = "Puzzle";
            KnowledgeRequired = 1;
            PracticeRequired = 0;
            IsSpell = true;
        }

        /** The Book of Spells */
        public Spell(int num)
        {
            Index = num;
            IsGameObject = true;
            IsItem = true;
            IsEnchantment = true;
            IsSpell = true;

            switch (num)
            {
                case 0:
                    Name = "Spell";
                    Description = "A Wizard threw caution to the wind to make this one...";
                    Cost = 42;
                    ManaCost = 1;
                    Family = "Puzzle";
                    KnowledgeRequired = 1;
                    PracticeRequired = 0;
                    break;
                case 1:
                    Name = "Enigma";
                    Description = "A Sorceror had a thought, then lost it...";
                    Cost = 225;
                    ManaCost = 4;
                    Family = "Puzzle";
                    KnowledgeRequired = 5;
                    PracticeRequired = 3;
                    break;
                case 2:
                    Name = "Question";
                    Description = "What is this?";
                    Cost = 9000;
                    ManaCost = 12;
                    Family = "Puzzle";
                    KnowledgeRequired = 18;
                    PracticeRequired = 25;
                    break;
                case 3:
                    Name = "Amnesia";
                    Description = "The victim won't remember who they are";
                    Cost = 2000;
                    ManaCost = 15;
                    Family = "Puzzle";
                    KnowledgeRequired = 6;
                    PracticeRequired = 6;
                    break;
                case 4:
                    Name = "Summon Giant Squid";
                    Description = "To worship the depths and to pull something out, the life.";
                    Cost = 330;
                    ManaCost = 3;
                    Family = "Cthulu";
                    KnowledgeRequired = 3;
                    PracticeRequired = 2;
                    break;
                case 5:
                    Name = "Summon Kraken";
                    Description = "A wave from the beast of the deep consumes all land.";
                    Cost = 5555;
                    ManaCost = 20;
                    Family = "Cthulu";
                    KnowledgeRequired = 14;
                    PracticeRequired = 2;
                    break;
                case 6:
                    Name = "Summon God";
                    Description = "Cthulu himself brings down the wrath of 11 Hells";
                    Cost = 99999;
                    ManaCost = 1;
                    Family = "Cthulu";
                    KnowledgeRequired = 99;
                    PracticeRequired = 2;
                    break;
                case 7:
                    Name = "Devour";
                    Description = "The mouth is just as bad...";
                    Cost = 200;
                    ManaCost = 4;
                    Family = "Cthulu";
                    KnowledgeRequired = 8;
                    PracticeRequired = 2;
                    break;
                case 8:
                    Name = "Screech";
                    Description = "Cats have used magic for years.  Can't you hear the incantations?";
                    Cost = 20;
                    ManaCost = 1;
                    Family = "Felyne";
                    KnowledgeRequired = 1;
                    PracticeRequired = 1;
                    break;
                case 9:
                    Name = "Swipes";
                    Description = "A Cat on command, to scratch the enemy away!!!";
                    Cost = 20;
                    ManaCost = 1;
                    Family = "Felyne";
                    KnowledgeRequired = 1;
                    PracticeRequired = 1;
                    break;
                case 10:
                    Name = "Magic Mutter";
                    Description = "The purring sound is actually fatal to the right ears.";
                    Cost = 20;
                    ManaCost = 1;
                    Family = "Felyne";
                    KnowledgeRequired = 1;
                    PracticeRequired = 1;
                    break;
                case 11:
                    Name = "Small Heal";
                    Description = "Live to fight another day.";
                    Cost = 5;
                    ManaCost = 1;
                    Family = "Bandage";
                    KnowledgeRequired = 1;
                    PracticeRequired = 0;
                    break;
                case 12:
                    Name = "Full Limb Recovery";
                    Description = "A spare is always nice";
                    Cost = 10;
                    ManaCost = 2;
                    Family = "Bandage";
                    KnowledgeRequired = 3;
                    PracticeRequired = 1;
                    break;
                case 13:
                    Name = "Triage";
                    Description = "The Great Needle decides who lives and who dies.";
                    Cost = 150;
                    ManaCost = 3;
                    Family = "Bandage";
                    KnowledgeRequired = 11;
                    PracticeRequired = 2;
                    break;
                case 14:
                    Name = "Resurrection";
                    Description = "The only known way to escape Death.";
                    Cost = 4500;
                    ManaCost = 5;
                    Family = "Bandage";
                    KnowledgeRequired = 65;
                    PracticeRequired = 3;
                    break;
                case 15:
                    Name = "Fireball";
                    Description = "How's this to a snowball fight?  wait, what?  That's fire!!!!!";
                    Cost = 35;
                    ManaCost = 2;
                    Family = "Burn";
                    KnowledgeRequired = 2;
                    PracticeRequired = 1;
                    break;
                case 16:
                    Name = "Incinerate";
                    Description = "Superheat the air, to INCINERATEEEEEE...";
                    Cost = 1000;
                    ManaCost = 5;
                    Family = "Burn";
                    KnowledgeRequired = 5;
                    PracticeRequired = 1;
                    break;
                case 17:
                    Name = "Eruption";
                    Description = "Send all the heat energy around you in one focused pulse.";
                    Cost = 2000;
                    ManaCost = 10;
                    Family = "Burn";
                    KnowledgeRequired = 10;
                    PracticeRequired = 2;
                    break;
                case 18:
                    Name = "Earthquake";
                    Description = "Ask the Tectonic Plates to move for you.";
                    Cost = 1789;
                    ManaCost = 12;
                    Family = "Terran";
                    KnowledgeRequired = 12;
                    PracticeRequired = 0;
                    break;
                case 19:
                    Name = "Precipitate";
                    Description = "Water falls from the sky.";
                    Cost = 25;
                    ManaCost = 2;
                    Family = "Vapor";
                    KnowledgeRequired = 2;
                    PracticeRequired = 2;
                    break;
                case 20:
                    Name = "Evaporate";
                    Description = "Water returns to the sky.";
                    Cost = 25;
                    ManaCost = 2;
                    Family = "Vapor";
                    KnowledgeRequired = 2;
                    PracticeRequired = 2;
                    break;
                case 21:
                    Name = "Condensate";
                    Description = "Water gathers nearby.";
                    Cost = 25;
                    ManaCost = 2;
                    Family = "Vapor";
                    KnowledgeRequired = 2;
                    PracticeRequired = 2;
                    break;
                case 22:
                    Name = "Meditate";
                    Description = "It takes years to master this one technique.";
                    Cost = 15;
                    ManaCost = 1;
                    Family = "Brikin";
                    KnowledgeRequired = 1;
                    PracticeRequired = 100;
                    break;
                case 23:
                    Name = "Transcendance";
                    Description = "Pull away from suffering.";
                    Cost = 1;
                    ManaCost = 10;
                    Family = "Brikin";
                    KnowledgeRequired = 100;
                    PracticeRequired = 10000;
                    break;
                case 24:
                    Name = "Tempt";
                    Description = "Use the enemies own desires against them.";
                    Cost = 500;
                    ManaCost = 13;
                    Family = "Brikin";
                    KnowledgeRequired = 130;
                    PracticeRequired = 15;
                    break;
                case 25:
                    Name = "Awaken";
                    Description = "The Soul of Magic Born into the Awakened One.";
                    Cost = 1000000;
                    ManaCost = 1;
                    Family = "Brikin";
                    KnowledgeRequired = 200;
                    PracticeRequired = 1000000;
                    break;
                default:
                    Name = "Spell";
                    Description = "A Wizard threw caution to the wind to make this one...";
                    Cost = 42;
                    ManaCost = 1;
                    Family = "Puzzle";
                    KnowledgeRequired = 1;
                    PracticeRequired = 0;
                    break;

            }
        }
    }
}
