// (Boss) Monster Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    // Boss Class
    public class Boss
    {
        // Variables to represent Boss Stats
        private int health;
        private int attack;
        private int defense;
        private int speed;
        private String name;
        private String enemyDescription;
        private int xlocation;
        private int ylocation;
        private Boolean isalive = true;

        // Properties to access Boss Variables
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public String Name { get; set; }
        public String EnemyDescription { get; set; }
        public int Xlocation { get; set; }
        public int Ylocation { get; set; }
        public Boolean Isalive { get; set; }

       // Default Boss (No-arg) Constructor
        public Boss()
        {
            Health = 300;
            Attack = 50;
            Defense = 50;
            Speed = 100;
            Name = "Sagridell";
            EnemyDescription = "The king is always being challenged for his position.";

        }

        // Player-defined Boss (All Custom) Constructor
        public Boss(int hp, int att, int def, int sp, String n, String ed)
        {
            Health = hp;
            Attack = att;
            Defense = def;
            Speed = sp;
            Name = n;
            EnemyDescription = ed;
        }

        // Player-defined Boss (Stats Custom) Constructor
        public Boss(int hp, int att, int def, int sp) : base()
        {
            Health = hp;
            Attack = att;
            Defense = def;
            Speed = sp;
        }

        // Player-defined Boss (Name & Description Custom) Constructor
        public Boss(String n, String ed) : base()
        {
            Name = n;
            EnemyDescription = ed;
        }

        // Story-defined Boss (mob selector) Constructor
        public Boss(String mob) : base()
        {
            switch (mob)
            {
                case "1":
                    Health = 25;
                    Attack = 4;
                    Defense = 1;
                    Speed = 8;
                    Name = "Galylum";
                    EnemyDescription = "Sagridell took this child away from his family when he was only 3 years old.\nAll he knows is what Sagridell has told.";
                    break;
                case "2":
                    Health = 34;
                    Attack = 14;
                    Defense = 2;
                    Speed = 8;
                    Name = "Zibrick";
                    EnemyDescription = "24 hours a day Zibrick can be found wrestling Sagres, for fun.";
                    break;
                case "3":
                    Health = 45;
                    Attack = 24;
                    Defense = 3;
                    Speed = 1;
                    Name = "Onsom";
                    EnemyDescription = "The quiet before the storm, is a phrase that explains Onsom.";
                    break;
                case "4":
                    Health = 100;
                    Attack = 44;
                    Defense = 22;
                    Speed = 33;
                    Name = "Drickiya";
                    EnemyDescription = "Somebody has to stop you.  I guess it will be me.";
                    break;
                default:
                    break;
                
            }
        }
    }
}
