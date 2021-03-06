﻿// (Boss) Class (Tier 3)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    // Boss Class
    //
    // Inherits from Character Abstract Class

    public class Boss : T2Character
    {
        // Variables
        private int health;
        private int attack;
        private int defense;
        private int speed;
        private String name;
        private String description;
        private int xlocation;
        private int ylocation;
        private Boolean isalive = true;

        // Every Game Object must implement (Name, Description, IsGameObject)
        public override String Name { get; set; }
        public override String Description { get; set; }
        public override bool IsGameObject { get; set; }

        // Every Character must implement (Health, Attack, Defense, Speed)
        public override int Health { get; set; }
        public override int Attack { get; set; }
        public override int Defense { get; set; }
        public override int Speed { get; set; }
        
        // Additional Properties for the Boss Class
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
            Description = "The king is always being challenged for his position.";

        }

        // Player-defined Boss (All Custom) Constructor
        public Boss(int hp, int att, int def, int sp, String n, String ed)
        {
            Health = hp;
            Attack = att;
            Defense = def;
            Speed = sp;
            Name = n;
            Description = ed;
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
            Description = ed;
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
                    Description = "Sagridell took this child away from his family when he was only 3 years old.\nAll he knows is what Sagridell has told.";
                    break;
                case "2":
                    Health = 34;
                    Attack = 14;
                    Defense = 2;
                    Speed = 8;
                    Name = "Zibrick";
                    Description = "24 hours a day Zibrick can be found wrestling Sagres, for fun.";
                    break;
                case "3":
                    Health = 45;
                    Attack = 24;
                    Defense = 3;
                    Speed = 1;
                    Name = "Onsom";
                    Description = "The quiet before the storm, is a phrase that explains Onsom.";
                    break;
                case "4":
                    Health = 100;
                    Attack = 44;
                    Defense = 22;
                    Speed = 33;
                    Name = "Drickiya";
                    Description = "Somebody has to stop you.  I guess it will be me.";
                    break;
                default:
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
