using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    public class Tile
    {
        /** Identify the Variables */
        private String terrain;
        private String type;
        private String description;
        private int xcoordinate;
        private int ycoordinate;

        /** Properties for the Variables */
        public String Terrain { get; set; }
        public String Type { get; set; }
        public String Description { get; set; }
        public int Xcoordinate { get; set; }
        public int Ycoordinate { get; set; }

        /** No-Arg Constructor */
        public Tile()
        {
            Terrain = "NORMAL";
            Type = "NORMAL";
            Description = "This is the tile that shouldn't have made it in the game.";
        }

        /** Player-Defined Constructor */
        public Tile(String terrain, String type, int x, int y)
        {
            Terrain = terrain;
            Type = type;
            Xcoordinate = x;
            Ycoordinate = y;
            switch (Terrain)
            {
                case "1":
                    Description = "Insert description of Terrain 1";
                    break;
                case "2":
                    Description = "Insert description of Terrain 2";
                    break;
                case "3":
                    Description = "Insert description of Terrain 3";
                    break;
                case "4":
                    Description = "Insert description of Terrain 4";
                    break;
                case "5":
                    Description = "Insert description of Terrain 5";
                    break;
            }
        }

        /** Story-Defined Constructor */
        public Tile(String terrain, String type)
        {
            Terrain = terrain;
            Type = type;
            switch (Terrain)
            {
                case "1":
                    Description = "Insert description of Terrain 1";
                    break;
                case "2":
                    Description = "Insert description of Terrain 2";
                    break;
                case "3":
                    Description = "Insert description of Terrain 3";
                    break;
                case "4":
                    Description = "Insert description of Terrain 4";
                    break;
                case "5":
                    Description = "Insert description of Terrain 5";
                    break;
            }
        }

    }
}
