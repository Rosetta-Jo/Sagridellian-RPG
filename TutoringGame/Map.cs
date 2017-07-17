using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    public class Map
    {
        /** Identify the Variables */
        private int nRows;
        private int nColumns;
        private Tile[,] worldMap;
        private String title;

        /** Properties for the Variables */
        public int NRows { get; set; }
        public int NColumns { get; set; }
        public Tile[,] WorldMap { get; set; }
        public String Title { get; set; }

        /** No-Arg Constructor */
        public Map()
        {
            NRows = 10;
            NColumns = 10;

            WorldMap = new Tile[NRows, NColumns];

            for (int i = 0; i < NRows; i++)
            {
                for (int j = 0; j < NColumns; j++)
                {
                    WorldMap[i, j] = new Tile();
                    WorldMap[i, j].Xcoordinate = i;
                    WorldMap[i, j].Ycoordinate = j;
                }
            }
        }

        /** Player-Defined Constructor */
        public Map(int rows, int columns, String mapTitle)
        {
            NRows = rows;
            NColumns = columns;
            Title = mapTitle;

            WorldMap = new Tile[NRows, NColumns];

            for (int i = 0; i < NRows; i++)
            {
                for (int j = 0; j < NColumns; j++)
                {
                    WorldMap[i, j] = new Tile();
                    WorldMap[i, j].Xcoordinate = i;
                    WorldMap[i, j].Ycoordinate = j;
                }
            }
        }

        /** Story-Defined Constructor */
        public Map(int rows, int columns)
        {
            NRows = rows;
            NColumns = columns;
            Title = "Blarrgh";

            WorldMap = new Tile[NRows, NColumns];

            for (int i = 0; i < NRows; i++)
            {
                for (int j = 0; j < NColumns; j++)
                {
                    WorldMap[i, j] = new Tile();
                    WorldMap[i, j].Xcoordinate = i;
                    WorldMap[i, j].Ycoordinate = j;
                }
            }
        }

        /** Method to catch the specific tile, TileAt(x, y)... */
        public Tile TileAt(int x, int y)
        {
            Tile ourTile;
            ourTile = WorldMap[x, y];
            return ourTile;
        }

        /** Method to display the map... */
        public void displayMap(Player p1, Map wm1)
        {
            Console.WriteLine("{0}", Title);
            for (int j = 0; j < NColumns; j++)
            {
                Console.Write("*---");
            }
            Console.WriteLine("*");
            for (int i = 0; i < NRows; i++)
            {
                Console.Write("|");
                for (int j = 0; j < NColumns; j++)
                {
                    if (occupied(p1, i, j))
                    {
                        Console.Write(" O |");
                    }
                    else if (MonsterGPS(wm1.TileAt(i, j)))
                    {
                        Console.Write(" M |");
                    }
                    else if (ItemGPS(wm1.TileAt(i, j)))
                    {
                        Console.Write(" I |");
                    }
                    else if(BossGPS(wm1.TileAt(i, j)))
                    {
                        Console.Write(" B |");
                    }
                    else
                    {
                        Console.Write("   |");
                    }
                }
                Console.WriteLine();
                for (int j = 0; j < NColumns; j++)
                {
                    Console.Write("*---");
                }
                Console.WriteLine("*");
            }
        }

        /** Method to print off Monster Tiles Cheat Code... */
        public Boolean MonsterGPS(Tile t)
        {
            if (t.Type == "MONSTER")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /** Method to print off Monster Tiles Cheat Code... */
        public Boolean BossGPS(Tile t)
        {
            if (t.Type == "BOSS")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /** method to print off Item Tiles Cheat Code... */
        public Boolean ItemGPS(Tile t)
        {
            if (t.Type == "ITEM")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /** Method to check if character is on square... */
        public Boolean occupied(Player p1, int x, int y)
        {
            if (p1.X == x && p1.Y == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
