using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    public class Boss
    {
        /** Identify the Variables */
        private int health;
        private int attack;
        private int defense;
        private int speed;
        private String name;
        private String enemyDescription;
        private int xlocation;
        private int ylocation;
        private Boolean isalive = true;

        /** Properties for the Variables */
        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }
        public String Name { get; set; }
        public String EnemyDescription { get; set; }
        public int Xlocation { get; set; }
        public int Ylocation { get; set; }
        public Boolean Isalive { get; set; }

        /** No-Arg Constructor */
        public Boss()
        {
            Health = 100;
            Attack = 12;
            Defense = 18;
            Speed = 84;
            Name = "Sagridell";
            EnemyDescription = "The king is always being challenged for his position.";

        }

        /** Player-Defined Constructor */
        public Boss(int hp, int att, int def, int sp, String n, String ed)
        {
            Health = hp;
            Attack = att;
            Defense = def;
            Speed = sp;
            Name = n;
            EnemyDescription = ed;
        }

        /** Story-Defined Constructor */
        public Boss(String mob)
        {

        }
    }
}
