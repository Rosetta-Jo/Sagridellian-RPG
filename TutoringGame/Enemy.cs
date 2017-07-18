// (Enemy) Class (Tier 3)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    // Enemy Class
    //
    // Inherits from Character Abstract Class

    public class Enemy : T2Character 
    {
        // Variables
        private int health;
        private int attack;
        private int defense;
        private int speed;
        private String name;
        private String description;

        // Every Game Object must implement (Name, Description, IsGameObject)
        public override String Name { get; set; }
        public override String Description { get; set; }
        public override bool IsGameObject { get; set; }

        // Every Character must implement (Health, Attack, Defense, Speed)
        public override int Health { get; set; }
        public override int Attack { get; set; }
        public override int Defense { get; set; }
        public override int Speed { get; set; }

        // Default Enemy (No-arg) Constructor
        public Enemy()
        {
            Health = 4;
            Attack = 4;
            Defense = 4;
            Speed = 4;
            Name = "Mobman";
            Description = "Good luck.  This little fucker has high def.";
        }

        // Player-defined Enemy (All Custom) Constructor
        public Enemy(int hp, int att, int def, int sp, String n, String ed)
        {
            Health = hp;
            Attack = att;
            Defense = def;
            Speed = sp;
            Name = n;
            Description = ed;
        }



        // THIS ALL NEEDS TO BE MOVED TO A DATABASE




        // Story-defined Enemy (mob selector) Constructor
        public Enemy(String mob)
        {
            switch (mob)
            {
                case "1":
                    Health = 5;
                    Attack = 2;
                    Defense = 1;
                    Speed = 4;
                    Name = "Sagride";
                    Description = "Sagride is just a squire for one of the Sagridellian 9th Flank.";
                    break;
                case "2":
                    Health = 10;
                    Attack = 10;
                    Defense = 0;
                    Speed = 1;
                    Name = "Sagresh";
                    Description = "Beware Sagresh's strike.  It is that of a BERSERKA!.";
                    break;
                case "3":
                    Health = 2;
                    Attack = 2;
                    Defense = 12;
                    Speed = 2;
                    Name = "Sagul";
                    Description = "Sagul has a very strong armour that he nevers walks around without.";
                    break;
                case "4":
                    Health = 1;
                    Attack = 12;
                    Defense = 1;
                    Speed = 1;
                    Name = "Saggas";
                    Description = "The guard dog has a bite from hell.";
                    break;
                case "5":
                    Health = 45;
                    Attack = 1;
                    Defense = 1;
                    Speed = 5;
                    Name = "Sagiru";
                    Description = "The keeper of the potions, Sagiru, is in good health.";
                    break;
                case "6":
                    Health = 2;
                    Attack = 25;
                    Defense = 0;
                    Speed = 1;
                    Name = "Sage";
                    Description = "NO TIME TO LOSE, KILL HIM NOW!!!";
                    break;
                case "7":
                    Health = 15;
                    Attack = 5;
                    Defense = 5;
                    Speed = 0;
                    Name = "Saggitarius";
                    Description = "Not all knights can wear armour and hold a big axe at the same time.";
                    break;
                case "8":
                    Health = 0;
                    Attack = 25;
                    Defense = 25;
                    Speed = 0;
                    Name = "Sagonquan";
                    Description = "He's been dead for a while.  They just carry him around for the memory.";
                    break;
                case "9":
                    Health = 12;
                    Attack = 4;
                    Defense = 6;
                    Speed = 8;
                    Name = "Sagnam";
                    Description = "A very skilled swordsman that has killed 200 knights for his title.";
                    break;
                case "10":
                    Health = 15;
                    Attack = 15;
                    Defense = 15;
                    Speed = 15;
                    Name = "Sagargry";
                    Description = "A Giant, that was knighted during the 3rd conflict.  He was the only survivor.";
                    break;
                case "11":
                    Health = 5;
                    Attack = 0;
                    Defense = 0;
                    Speed = 0;
                    Name = "Sag";
                    Description = "Lucky thing Sag is a pacifist.  Otherwise there would be problems.";
                    break;
                case "12":
                    Health = 13;
                    Attack = 9;
                    Defense = 8;
                    Speed = 5;
                    Name = "Sagite";
                    Description = "An overall powerful knight who loves the lance.";
                    break;
            }
        }

        // Just a placeholder for now, for any abstract methods we may want implemented.
        public override void Reset()
        {
            throw new NotImplementedException();
        }
    }
}
