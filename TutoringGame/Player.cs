using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    public class Player
    {
        /** Identify the Variables */
        private int health;
        private int attack;
        private int defense;
        private int speed;
        private String playerType;
        private String classDescription;
        private int x;
        private int y;
        private int level;
        private int killcount;

        Random rand = new Random();


        /** Properties for the Variables */
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public String PlayerType { get; set; }
        public String ClassDescription { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Level { get; set; }
        public int Killcount { get; set; }

        /** No-Arg Constructor */
        public Player()
        {
            Level = 1;
            Killcount = 0;
            Health = 5;
            Attack = 4;
            Defense = 1;
            Speed = 2;
            PlayerType = "Vagrant";
            ClassDescription = "A poor hobo that was left with nothing.";
        }

        /** Player-Defined Constructor */
        public Player(int hp, int att, int def, int sp, String pt, String cd)
        {
            Level = 1;
            Killcount = 0;
            Health = hp;
            Attack = att;
            Defense = def;
            Speed = sp;
            PlayerType = pt;
            ClassDescription = cd;
        }

        /** Story-Defined Constructor */
        public Player(String playertype)
        {
            Level = 1;
            Killcount = 0;

            switch (playertype.ToUpper())
            {
                case "SWORDSMAN":
                    Health = 8;
                    Attack = 5;
                    Defense = 2;
                    Speed = 5;
                    PlayerType = "Swordsman";
                    ClassDescription = "Good with a sword, high attack, high speed, low defense.";
                    break;
                case "BERSERKER":
                    Health = 6;
                    Attack = 10;
                    Defense = 5;
                    Speed = 1;
                    PlayerType = "Berserker";
                    ClassDescription = "CRAZYYYY STRONG!!!, but slow.";
                    break;
                case "ARCHER":
                    Health = 10;
                    Attack = 3;
                    Defense = 0;
                    Speed = 5;
                    PlayerType = "Archer";
                    ClassDescription = "Fast with decent attack, no defense.";
                    break;
                case "HALBERDIER":
                    Health = 8;
                    Attack = 2;
                    Defense = 4;
                    Speed = 4;
                    PlayerType = "Halberdier";
                    ClassDescription = "Carries a big long axe, decent stats all-around.";
                    break;
                case "MAGE":
                    Health = 5;
                    Attack = 12;
                    Defense = 0;
                    Speed = 5;
                    PlayerType = "Mage";
                    ClassDescription = "Weak as shit.  But hits really hard.";
                    break;
                    /** Create more characters later, right here,,, as new Cases 
                    like 
                    case "NAME"
                    stat = bla;
                    stat = bla;
                    stat = bla;
                    break;
                    */
            }
        }

        /** The Stats page for the Player... */
        public void printStats()
        {
            Console.WriteLine("uuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu");
            Console.WriteLine("                   {0}", PlayerType);
            Console.WriteLine("uuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu");
            Console.WriteLine("Level: {0}", Level);
            Console.WriteLine("Enemy Kill Count: {0}", Killcount);
            Console.WriteLine("Class Description: {0}", ClassDescription);
            Console.WriteLine("uuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu");
            Console.WriteLine("                    Health: {0}", Health);
            Console.WriteLine("                    Attack: {0}", Attack);
            Console.WriteLine("                   Defense: {0}", Defense);
            Console.WriteLine("                     Speed: {0}", Speed);
            Console.WriteLine("uuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu");
        }

        public void levelUp()
        {
            Console.WriteLine("Your increasing killcount has leveled you up.");
            switch (rand.Next(4))
            {
                case 0:
                    Health++;
                    break;
                case 1:
                    Attack++;
                    break;
                case 2:
                    Defense++;
                    break;
                case 3:
                    Speed++;
                    break;
            }
            Level++;
            printStats();
        }
    }
}
