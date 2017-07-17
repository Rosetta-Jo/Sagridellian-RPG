using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    public class Enemy
    {
        /** Identify the Variables */
        private int health;
        private int attack;
        private int defense;
        private int speed;
        private String name;
        private String enemyDescription;

        /** Properties for the Variables */
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public String Name { get; set; }
        public String EnemyDescription { get; set; }

        /** No-Arg Constructor */
       public Enemy()
        {
            Health = 4;
            Attack = 4;
            Defense = 4;
            Speed = 4;
            Name = "Mobman";
            EnemyDescription = "Good luck.  This little fucker has high def.";

        }

        /** Player-Defined Constructor */
        public Enemy(int hp, int att, int def, int sp, String n, String ed)
        {
            Health = hp;
            Attack = att;
            Defense = def;
            Speed = sp;
            Name = n;
            EnemyDescription = ed;
        }

        /** Story-Defined Constructor */
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
                    EnemyDescription = "Sagride is just a squire for one of the Sagridellian 9th Flank.";
                    break;
                case "2":
                    Health = 10;
                    Attack = 10;
                    Defense = 0;
                    Speed = 1;
                    Name = "Sagresh";
                    EnemyDescription = "Beware Sagresh's strike.  It is that of a BERSERKA!.";
                    break;
                case "3":
                    Health = 2;
                    Attack = 2;
                    Defense = 12;
                    Speed = 2;
                    Name = "Sagul";
                    EnemyDescription = "Sagul has a very strong armour that he nevers walks around without.";
                    break;
                case "4":
                    Health = 1;
                    Attack = 12;
                    Defense = 1;
                    Speed = 1;
                    Name = "Saggas";
                    EnemyDescription = "The guard dog has a bite from hell.";
                    break;
                case "5":
                    Health = 45;
                    Attack = 1;
                    Defense = 1;
                    Speed = 5;
                    Name = "Sagiru";
                    EnemyDescription = "The keeper of the potions, Sagiru, is in good health.";
                    break;
                case "6":
                    Health = 2;
                    Attack = 25;
                    Defense = 0;
                    Speed = 1;
                    Name = "Sage";
                    EnemyDescription = "NO TIME TO LOSE, KILL HIM NOW!!!";
                    break;
                case "7":
                    Health = 15;
                    Attack = 5;
                    Defense = 5;
                    Speed = 0;
                    Name = "Saggitarius";
                    EnemyDescription = "Not all knights can wear armour and hold a big axe at the same time.";
                    break;
                case "8":
                    Health = 0;
                    Attack = 25;
                    Defense = 25;
                    Speed = 0;
                    Name = "Sagonquan";
                    EnemyDescription = "He's been dead for a while.  They just carry him around for the memory.";
                    break;
                case "9":
                    Health = 12;
                    Attack = 4;
                    Defense = 6;
                    Speed = 8;
                    Name = "Sagnam";
                    EnemyDescription = "A very skilled swordsman that has killed 200 knights for his title.";
                    break;
                case "10":
                    Health = 15;
                    Attack = 15;
                    Defense = 15;
                    Speed = 15;
                    Name = "Sagargry";
                    EnemyDescription = "A Giant, that was knighted during the 3rd conflict.  He was the only survivor.";
                    break;
                case "11":
                    Health = 5;
                    Attack = 0;
                    Defense = 0;
                    Speed = 0;
                    Name = "Sag";
                    EnemyDescription = "Lucky thing Sag is a pacifist.  Otherwise there would be problems.";
                    break;
                case "12":
                    Health = 13;
                    Attack = 9;
                    Defense = 8;
                    Speed = 5;
                    Name = "Sagite";
                    EnemyDescription = "An overall powerful knight who loves the lance.";
                    break;
            }
        }
    }
}
