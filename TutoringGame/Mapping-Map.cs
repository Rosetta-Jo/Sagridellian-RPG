// (Map) Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    // Map Class
    public class Map
    {
        // Variables
        private int nRows;
        private int nColumns;
        private Tile[,] worldMap;
        private String title;

        // Properties
        public int NRows { get; set; }
        public int NColumns { get; set; }
        public Tile[,] WorldMap { get; set; }
        public String Title { get; set; }

        // Default Map (No-arg) Constructor
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

        // Player-defined Map (All Custom) Constructor
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

        // Story-defined Map (mob selector) Constructor
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

        // Tile Catching Method
        public Tile TileAt(int x, int y)
        {
            Tile ourTile;
            ourTile = WorldMap[x, y];
            return ourTile;
        }

        // Display Map Method
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

        // Find Monster Tile Method
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

        // Find Boss Tile Method
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
        
        // Find Item Tile Method
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
        
        // Find Character Tile Method
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
