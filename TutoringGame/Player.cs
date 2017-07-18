// (Player) playable Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    // Player Class
    public class Player : Character
    {
        //Variables
        private int health;
        private int attack;
        private int defense;
        private int speed;
        private String name;
        private String description;
        private int x;
        private int y;
        private int level;
        private int killcount;

        // Random Number Generator
        Random rand = new Random();

        // Properties
        public override int Health { get; set; }
        public override int Attack { get; set; }
        public override int Defense { get; set; }
        public override int Speed { get; set; }
        public override String Name { get; set; }
        public override String Description { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Level { get; set; }
        public int Killcount { get; set; }

        // Default Player (No-arg) Constructor
        public Player()
        {
            Level = 1;
            Killcount = 0;
            Health = 5;
            Attack = 4;
            Defense = 1;
            Speed = 2;
            Name = "Vagrant";
            Description = "A poor hobo that was left with nothing.";
        }

        // Player-defined Player (All Custom) Constructor
        public Player(int hp, int att, int def, int sp, String pt, String cd)
        {
            Level = 1;
            Killcount = 0;
            Health = hp;
            Attack = att;
            Defense = def;
            Speed = sp;
            Name = pt;
            Description = cd;
        }

        // Story-defined Player (player selector) Constructor
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
                    Name = "Swordsman";
                    Description = "Good with a sword, high attack, high speed, low defense.";
                    break;
                case "BERSERKER":
                    Health = 6;
                    Attack = 10;
                    Defense = 5;
                    Speed = 1;
                    Name = "Berserker";
                    Description = "CRAZYYYY STRONG!!!, but slow.";
                    break;
                case "ARCHER":
                    Health = 10;
                    Attack = 3;
                    Defense = 0;
                    Speed = 5;
                    Name = "Archer";
                    Description = "Fast with decent attack, no defense.";
                    break;
                case "HALBERDIER":
                    Health = 8;
                    Attack = 2;
                    Defense = 4;
                    Speed = 4;
                    Name = "Halberdier";
                    Description = "Carries a big long axe, decent stats all-around.";
                    break;
                case "MAGE":
                    Health = 5;
                    Attack = 12;
                    Defense = 0;
                    Speed = 5;
                    Name = "Mage";
                    Description = "Weak as shit.  But hits really hard.";
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

        // Statistics UI Method
        public void printStats()
        {
            Console.WriteLine("uuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu");
            Console.WriteLine("                   {0}", Name);
            Console.WriteLine("uuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu");
            Console.WriteLine("Level: {0}", Level);
            Console.WriteLine("Enemy Kill Count: {0}", Killcount);
            Console.WriteLine("Class Description: {0}", Description);
            Console.WriteLine("uuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu");
            Console.WriteLine("                    Health: {0}", Health);
            Console.WriteLine("                    Attack: {0}", Attack);
            Console.WriteLine("                   Defense: {0}", Defense);
            Console.WriteLine("                     Speed: {0}", Speed);
            Console.WriteLine("uuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuuu");
        }

        // Level Up Method
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

        // Just a placeholder for now, for any abstract methods we may want implemented.
        public override void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
