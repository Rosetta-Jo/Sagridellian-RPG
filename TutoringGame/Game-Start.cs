/** Josiah Reynolds
 * 
 * designed September 2016
 * found again 7/8/2017
 * work restarted on 7/8/2017
 * maintained and worked on so far by Josiah Reynolds, and Joshua Herndon
 * 
 * 7/9 - program looked over and documentation
 * 
 */

 // (Program) main game Class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoringGame
{
    // Program Class 
    public class Program
    {
        // Main Method
        public static void Main(string[] args)
        {
            // Variables
            int rows;
            int columns;
            int player1Attack;
            int player1Defense;
            int player1Health;
            int player1Speed;
            String player1TypeChoice;
            String player1Name;
            String player1Class;
            String title;

            // Random Number Generator
            Random rand = new Random();

            // Player Instance
            Player player1 = new Player();

            // Map Instance
            Map worldmap = new Map();

            // Flag for game ending
            Boolean wonGame = false;

           // Each Player Class Instance
            Player xswordsman = new Player("Swordsman");
            Player xberserker = new Player("Berserker");
            Player xarcher = new Player("Archer");
            Player xhalberdier = new Player("Halberdier");
            Player xmage = new Player("Mage");
            Enemy xenemey = new Enemy();

            // Game Introduction
            Console.Clear();
            //Console.WriteLine("Welcome to The Tutoring RPG...");
            Console.WriteLine("----- Old - Timey Text RPG -----");

            // Map Creation
            Console.WriteLine("What game-map would you like to play on?");
            Console.WriteLine("\n1. Sagridell 9th Flank\n2. Sagridell Inner Flank\n3. Sagridell King's Chamber\n4. Custom-made");
            // Switch statement to decide the type of map
            switch (Console.ReadLine().ToUpper()){
                case "1":
                case "SAGRIDELL 9TH FLANK":
                    worldmap = new Map(5, 8);
                    worldmap.Title = "Sagridell 9th Flank";
                    worldmap.TileAt(1, 0).Type = "MONSTER";
                    worldmap.TileAt(1, 1).Type = "MONSTER";
                    worldmap.TileAt(1, 2).Type = "MONSTER";
                    worldmap.TileAt(0, 2).Type = "MONSTER";
                    worldmap.TileAt(3, 0).Type = "MONSTER";
                    worldmap.TileAt(3, 1).Type = "MONSTER";
                    worldmap.TileAt(3, 2).Type = "MONSTER";
                    worldmap.TileAt(3, 3).Type = "MONSTER";
                    worldmap.TileAt(3, 4).Type = "MONSTER";
                    worldmap.TileAt(3, 5).Type = "MONSTER";
                    worldmap.TileAt(3, 6).Type = "MONSTER";
                    worldmap.TileAt(2, 6).Type = "MONSTER";
                    worldmap.TileAt(1, 6).Type = "MONSTER";
                    worldmap.TileAt(0, 6).Type = "MONSTER";
                    worldmap.TileAt(1, 7).Type = "MONSTER";
                    worldmap.TileAt(4, 4).Type = "MONSTER";
                    worldmap.TileAt(2, 4).Type = "ITEM";
                    worldmap.TileAt(4, 7).Type = "ITEM";
                    worldmap.TileAt(0, 6).Type = "ITEM";
                    worldmap.TileAt(4, 7).Type = "BOSS";
                    break;

                case "2":
                case "SAGRIDELL INNER CIRCLE":
                    worldmap = new Map(7, 12);
                    worldmap.Title = "Sagridell Inner Circle";
                    worldmap.TileAt(3, 4).Type = "MONSTER";
                    worldmap.TileAt(3, 8).Type = "MONSTER";
                    worldmap.TileAt(4, 4).Type = "MONSTER";
                    worldmap.TileAt(4, 8).Type = "MONSTER";
                    worldmap.TileAt(5, 0).Type = "MONSTER";
                    worldmap.TileAt(5, 1).Type = "MONSTER";
                    worldmap.TileAt(5, 2).Type = "MONSTER";
                    worldmap.TileAt(5, 3).Type = "MONSTER";
                    worldmap.TileAt(5, 4).Type = "MONSTER";
                    worldmap.TileAt(5, 5).Type = "MONSTER";
                    worldmap.TileAt(5, 8).Type = "MONSTER";
                    worldmap.TileAt(6, 2).Type = "MONSTER";
                    worldmap.TileAt(6, 3).Type = "MONSTER";
                    worldmap.TileAt(6, 10).Type = "MONSTER";
                    worldmap.TileAt(6, 11).Type = "MONSTER";
                    worldmap.TileAt(4, 9).Type = "MONSTER";
                    worldmap.TileAt(2, 9).Type = "MONSTER";
                    worldmap.TileAt(0, 9).Type = "MONSTER";
                    worldmap.TileAt(1, 9).Type = "MONSTER";
                    worldmap.TileAt(4, 10).Type = "MONSTER";
                    worldmap.TileAt(2, 0).Type = "MONSTER";
                    worldmap.TileAt(2, 1).Type = "MONSTER";
                    worldmap.TileAt(2, 2).Type = "MONSTER";
                    worldmap.TileAt(2, 3).Type = "MONSTER";
                    worldmap.TileAt(2, 4).Type = "MONSTER";
                    worldmap.TileAt(2, 5).Type = "MONSTER";
                    worldmap.TileAt(2, 6).Type = "MONSTER";
                    worldmap.TileAt(2, 8).Type = "MONSTER";
                    worldmap.TileAt(1, 4).Type = "MONSTER";
                    worldmap.TileAt(0, 6).Type = "MONSTER";
                    worldmap.TileAt(1, 7).Type = "MONSTER";
                    worldmap.TileAt(0, 4).Type = "MONSTER";
                    worldmap.TileAt(3, 5).Type = "ITEM";
                    worldmap.TileAt(3, 6).Type = "ITEM";
                    worldmap.TileAt(3, 7).Type = "ITEM";
                    worldmap.TileAt(4, 5).Type = "ITEM";
                    worldmap.TileAt(4, 6).Type = "ITEM";
                    worldmap.TileAt(4, 7).Type = "ITEM";
                    worldmap.TileAt(4, 7).Type = "BOSS";
                    break;

                case "3":
                case "SAGRIDELL KING'S CHAMBER":
                    worldmap = new Map(9, 16);
                    worldmap.Title = "Sagridell King's Chamber";
                    for(int s = 0; s < 9; s++)
                    {
                        for (int t = 0; t < 16; t++)
                        {
                            worldmap.TileAt(s, t).Type = "MONSTER";
                        }
                    }
                    worldmap.TileAt(4, 7).Type = "BOSS";
                    break;

                case "CUSTOM":
                case "4":
                    Console.WriteLine("How many rows on game map? (As an Integer < 20)");
                    rows = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How many columns on game map? (As an Integer < 20)");
                    columns = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the title of game map? (As a String)");
                    title = Console.ReadLine();
                    worldmap = new Map(rows, columns, title);
                    // Setting the Tile Types...
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            int choice = rand.Next(3);
                            switch (choice)
                            {
                                case 0:
                                    worldmap.TileAt(i, j).Type = "MONSTER";
                                    break;
                                case 1:
                                    worldmap.TileAt(i, j).Type = "ITEM";
                                    break;
                                case 2:
                                    worldmap.TileAt(i, j).Type = "NORMAL";
                                    break;
                            }
                        }
                    }
                    break;
            }

            // Check to make sure there is a map
            if (worldmap == null)
            {
                worldmap = new Map();
            }

            // Character Building
            Console.Clear();
            Console.WriteLine("Build your character from...");
            Console.WriteLine("\nCUSTOM-----------PRESET");
            switch (Console.ReadLine().ToUpper())
            {
                case "CUSTOM":
                    
                    // Prompt the user to enter all of their custom stats...
                    Console.WriteLine("What is your Character's Name? (As a String)");
                    player1Name = Console.ReadLine();
                    Console.WriteLine("Describe your Character's Class. (As a sentence of Strings)");
                    player1Class = Console.ReadLine();
                    Console.WriteLine("What is the attack rating of your character? (As an Integer <= 5)");
                    player1Attack = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the defense rating of your character? (As an Integer <= 5)");
                    player1Defense = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What is the speed rating of your character? (As an Integer <= 5)");
                    player1Speed = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("How much lifepoints does your character have? (As an Integer <= 20)");
                    player1Health = Convert.ToInt32(Console.ReadLine());

                    // Create the Custom player from the entered stats...
                    player1 = new Player(player1Health, player1Attack, player1Defense, player1Speed, player1Name, player1Class);
                    break;

                case "PRESET":

                    // Prompt the user to enter their desired class...
                    Console.WriteLine("What type of character are you?");// (SWORDSMAN, BERSERKER, ARCHER, HALBERDIER, MAGE)");
                    Console.WriteLine("{0}\t{1}\n\n{2}\t{3}\n\n{4}\t\t{5}\n\n{6}\t{7}\n\n{8}\t\t{9}", "SWORDSMAN", xswordsman.Description, 
                        "BERSERKER", xberserker.Description, "ARCHER", xarcher.Description, "HALBERDIER", xhalberdier.Description
                        , "MAGE", xmage.Description);

                    player1TypeChoice = Console.ReadLine().ToUpper();

                    // Create the Preset Player dependent upon what the player chose...
                    switch (player1TypeChoice)
                    {
                        case "SWORDSMAN":
                            player1 = new Player("Swordsman");
                            break;
                        case "BERSERKER":
                            player1 = new Player("Berserker");
                            break;
                        case "ARCHER":
                            player1 = new Player("Archer");
                            break;
                        case "HALBERDIER":
                            player1 = new Player("Halberdier");
                            break;
                        case "MAGE":
                            player1 = new Player("Mage");
                            break;
                    }
                    if (player1 == null)
                    {
                        player1 = new Player();
                    }
                    break;
            }
            if (player1 == null)
            {
                player1 = new Player();
            }

            // Game Objective
            Console.WriteLine("The Objective of the game is to either beat the boss or beat 999 enemies rendering the king without guard");
            Console.WriteLine("Just fight enemies on M squares, and Boss is on the B square.  Items on the I squares.");
            Console.ReadLine();
            
            // Place the Player
            player1.X = 0;
            player1.Y = 0;

            // The Game Loop
            while (player1.Health > 0 && worldmap != null)
            {
                Console.Clear();
                takeTurn(player1, worldmap);
                if (player1.Killcount == 999)
                {
                    wonGame = true;
                    break;
                }
            }
            if (!wonGame)
            {
                Console.WriteLine("You lost the game!");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("You won the game!");
            }
        }

        // Turn - Taking Method
        public static void takeTurn(Player p1, Map wm1)
        {
            Boolean madeMove = false;
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Move");
            Console.WriteLine("2. See Map");
            Console.WriteLine("3. See Personal Stats");
            Console.WriteLine("4. Quit");

            switch (Console.ReadLine().ToUpper())
            {
                case "MOVE":
                    Console.WriteLine("UP, DOWN, LEFT, RIGHT?");
                    switch (Console.ReadLine().ToUpper())
                    {
                        case "UP":
                            if (p1.X > 0)
                            {
                                p1.X -= 1;
                                madeMove = true;
                                wm1.displayMap(p1, wm1);
                            }
                            else
                            {
                                Console.WriteLine("That would move off the board.");
                                Console.ReadLine();
                            }
                            break;
                        case "DOWN":
                            if (p1.X < wm1.NRows-1)
                            {
                                p1.X += 1;
                                madeMove = true;
                                wm1.displayMap(p1, wm1);
                            }
                            else
                            {
                                Console.WriteLine("That would move off the board.");
                                Console.ReadLine();
                            }
                            break;
                        case "LEFT":
                            if (p1.Y > 0)
                            {
                                p1.Y -= 1;
                                madeMove = true;
                                wm1.displayMap(p1, wm1);
                            }
                            else
                            {
                                Console.WriteLine("That would move off the board.");
                                Console.ReadLine();
                            }
                            break;
                        case "RIGHT":
                            if (p1.Y < wm1.NColumns-1)
                            {
                                p1.Y += 1;
                                madeMove = true;
                                wm1.displayMap(p1, wm1);
                            }
                            else
                            {
                                Console.WriteLine("That would move off the board.");
                                Console.ReadLine();
                            }
                            break;
                        case "FAST":
                            int x = Convert.ToInt16(Console.ReadLine());
                            int y = Convert.ToInt16(Console.ReadLine());
                            p1.X = x;
                            p1.Y = y;
                            madeMove = true;
                            break;
                    }
                    break;
                case "SEE MAP":
                    Console.WriteLine();
                    wm1.displayMap(p1, wm1);
                    Console.WriteLine();
                    Console.ReadLine();
                    break;
                case "SEE PERSONAL STATS":
                    p1.printStats();
                    Console.WriteLine();
                    Console.ReadLine();
                    break;
                case "QUIT":
                    p1.Health = 0;
                    break;
            }

            if (madeMove)
            {
                activateSquare(wm1.TileAt(p1.X, p1.Y), p1);
            }
        }

        // Square - Activation Method
        public static void activateSquare(Tile square, Player p1)
        {
            switch (square.Type.ToUpper())
            {
                case "MONSTER":
                    Console.WriteLine("{0}", "This is a monster tile.");
                    activateBattle(p1);
                    break;
                case "ITEM":
                    Console.WriteLine("{0}", "This is an item tile.");
                    activateItem(p1);
                    break;
                case "NORMAL":
                    Console.WriteLine("{0}", "This is a normal tile.");
                    break;
                case "BOSS":
                    Console.WriteLine("{0}", "It's time to face a real foe.");
                    activateBoss(p1);
                    break;
            }
            Console.ReadLine();
        }
        
        // Boss - Battle - Activation Method
        public static void activateBoss(Player p1)
        {
            Boss b1 = new Boss();

            Console.WriteLine("It is here.");

            int temp1 = p1.Health;
            int temp2 = p1.Attack;
            int temp3 = p1.Defense;
            int temp4 = p1.Speed;

            // Code to handle the Battle Scene
            while (p1.Health > 0 && b1.Health > 0)
            {
                // Faster characters move
                if (p1.Speed >= b1.Speed)
                {
                    playersMove(p1, b1);
                }
                else
                {
                    enemysMove(p1, b1);
                }

                // Slower characters move
                if (p1.Health <= 0 || b1.Health <= 0)
                {
                    if (p1.Health <= 0)
                    {
                        Console.WriteLine("The Enemy has reduced your lifepoints to zero");
                    }
                    else
                    {
                        Console.WriteLine("You have defeated the enemy mob.");
                    }
                    break;
                }
                if (p1.Speed < b1.Speed)
                {
                    playersMove(p1, b1);
                }
                else
                {
                    enemysMove(p1, b1);
                }
            }
            if (p1.Health > 0)
            {
                p1.Killcount = 999;
                Console.WriteLine("You have killed the Final boss..");
                afterBattleStats(temp1, temp2, temp3, temp4, p1);
                
            }

            if (p1.Killcount == Math.Pow(p1.Level, 2))
            {
                p1.levelUp();
            }

            Console.ReadLine();
        }

        // Normal - Battle - Activation Method
        public static void activateBattle(Player p1)
        {
            Random rand = new Random();
            int enemy = rand.Next(1, 12);

            Console.WriteLine("Battle has been initiated.");
            Enemy e1 = new Enemy(enemy.ToString());

            Console.WriteLine("{0} has appeared.", e1.Name);
            Console.WriteLine("{0}", e1.Description);

            int temp1 = p1.Health;
            int temp2 = p1.Attack;
            int temp3 = p1.Defense;
            int temp4 = p1.Speed;

            // Code to handle the Battle Scene
            while(p1.Health > 0 && e1.Health > 0)
            {
                // Faster characters move
                if(p1.Speed >= e1.Speed)
                {
                    playersMove(p1, e1);
                }
                else
                {
                    enemysMove(p1, e1);
                }

                // Slower characters move
                if(p1.Health <= 0 || e1.Health <= 0)
                {
                    if(p1.Health <= 0)
                    {
                        Console.WriteLine("The Enemy has reduced your lifepoints to zero");
                    }
                    else
                    {
                        Console.WriteLine("You have defeated the enemy mob.");
                    }
                    break;
                }
                if (p1.Speed < e1.Speed)
                {
                    playersMove(p1, e1);
                }
                else
                {
                    enemysMove(p1, e1);
                }
            }
            if (p1.Health > 0)
            {
                p1.Killcount++;
                Console.WriteLine("Your killcount has increased by 1.");
                afterBattleStats(temp1, temp2, temp3, temp4, p1);
            }

            if(p1.Killcount == Math.Pow(p1.Level, 2))
            {
                p1.levelUp();
            }
            
            Console.ReadLine();
        }

        // Item - Activation Method
        public static void activateItem(Player p1)
        {
            Random rand = new Random();
            int item = rand.Next(1, 13);

            Console.WriteLine("There is an item laying here.");
            TheUsed i1 = new TheUsed(item.ToString());

            Console.WriteLine("The Item is a {0}.", i1.Name);
            Console.WriteLine("Description: {0}", i1.Itemdescription);

            int temp1 = p1.Health;
            int temp2 = p1.Attack;
            int temp3 = p1.Defense;
            int temp4 = p1.Speed;

            Console.WriteLine("Your options:\n\nUSE\t\tLEAVE");

            if (Console.ReadLine().ToUpper() == "USE")
            {
                switch (i1.Stat)
                {
                    case "HEALTH":
                        p1.Health += i1.Value;
                        break;
                    case "ATTACK":
                        p1.Attack += i1.Value;
                        break;
                    case "DEFENSE":
                        p1.Defense += i1.Value;
                        break;
                    case "SPEED":
                        p1.Speed += i1.Value;
                        break;
                    case "ALL":
                        p1.Health += i1.Value;
                        p1.Attack += i1.Value;
                        p1.Defense += i1.Value;
                        p1.Speed += i1.Value;
                        break;
                }
            }
        }

        // Player - Batttle - Turn Method
        public static void playersMove(Player p1, Enemy e1)
        {
            Console.WriteLine("Your options:\n\nATTACK, FOCUS, DEFEND, HEAL, CHECKSELF, CHECKENEMY");
            String choice = Console.ReadLine();
            switch (choice.ToUpper())
            {
                case "ATTACK":
                    if (p1.Attack > e1.Defense)
                    {
                        e1.Health -= (p1.Attack - e1.Defense);
                        Console.WriteLine("Player dealt {0} damage to enemy.", (p1.Attack - e1.Defense));
                    }
                    else
                    {
                        p1.Health -= 1;
                        e1.Health -= 1;
                        Console.WriteLine("The defense held no holes, but the scrambling hurt both (1).");
                    }
                    break;
                case "FOCUS":
                    p1.Attack += 2;
                    Console.WriteLine("You are focusing to prepare for strong attck (Attack up 2).");
                    break;
                case "DEFEND":
                    p1.Defense += 2;
                    Console.WriteLine("You are bracing yourself for impact (Defense up 2).");
                    break;
                case "HEAL":
                    p1.Health += 2;
                    Console.WriteLine("The short rest seems to have rejuvanated you a bit (Health up 2).");
                    break;
                case "CHECKSELF":
                    Console.WriteLine("Player LP: {0}", p1.Health);
                    Console.WriteLine("Player AP: {0}", p1.Attack);
                    Console.WriteLine("Player DP: {0}", p1.Defense);
                    Console.WriteLine("Player SP: {0}", p1.Speed);
                    break;
                case "CHECKENEMY":
                    Console.WriteLine("Enemy LP: {0}", e1.Health);
                    Console.WriteLine("Enemy AP: {0}", e1.Attack);
                    Console.WriteLine("Enemy DP: {0}", e1.Defense);
                    Console.WriteLine("Enemy SP: {0}", e1.Speed);
                    break;
            }

        }

        // Player - Battle - Boss - Turn Method
        public static void playersMove(Player p1, Boss e1)
        {
            Console.WriteLine("Your options:\n\nATTACK, FOCUS, DEFEND, HEAL, CHECKSELF, CHECKENEMY");
            String choice = Console.ReadLine();
            switch (choice.ToUpper())
            {
                case "ATTACK":
                    if (p1.Attack > e1.Defense)
                    {
                        e1.Health -= (p1.Attack - e1.Defense);
                        Console.WriteLine("Player dealt {0} damage to enemy.", (p1.Attack - e1.Defense));
                    }
                    else
                    {
                        p1.Health -= 1;
                        e1.Health -= 1;
                        Console.WriteLine("The defense held no holes, but the scrambling hurt both (1).");
                    }
                    break;
                case "FOCUS":
                    p1.Attack += 2;
                    Console.WriteLine("You are focusing to prepare for strong attck (Attack up 2).");
                    break;
                case "DEFEND":
                    p1.Defense += 2;
                    Console.WriteLine("You are bracing yourself for impact (Defense up 2).");
                    break;
                case "HEAL":
                    p1.Health += 2;
                    Console.WriteLine("The short rest seems to have rejuvanated you a bit (Health up 2).");
                    break;
                case "CHECKSELF":
                    Console.WriteLine("Player LP: {0}", p1.Health);
                    Console.WriteLine("Player AP: {0}", p1.Attack);
                    Console.WriteLine("Player DP: {0}", p1.Defense);
                    Console.WriteLine("Player SP: {0}", p1.Speed);
                    break;
                case "CHECKENEMY":
                    Console.WriteLine("Enemy LP: {0}", e1.Health);
                    Console.WriteLine("Enemy AP: {0}", e1.Attack);
                    Console.WriteLine("Enemy DP: {0}", e1.Defense);
                    Console.WriteLine("Enemy SP: {0}", e1.Speed);
                    break;
            }

        }

        // Enemys - Battle - Turn Method
        public static void enemysMove(Player p1, Enemy e1)
        {

            Random rand = new Random();
            switch (rand.Next(4))
            {
                case 0:
                    if (e1.Attack > p1.Defense)
                    {
                        p1.Health -= (e1.Attack - p1.Defense);
                        Console.WriteLine("Enemy dealt {0} damage to Player.", (e1.Attack - p1.Defense));
                    }
                    else
                    {
                        p1.Health -= 1;
                        e1.Health -= 1;
                        Console.WriteLine("Your defense didn't give, but the scrambling hurt you both (1).");
                    }
                    break;
                case 1:
                    e1.Defense++;
                    Console.WriteLine("Enemy is bracing itself against you.");
                    break;
                case 2:
                    e1.Health++;
                    Console.WriteLine("Enemy is licking its wounds.");
                    break;
                case 3:
                    e1.Attack++;
                    Console.WriteLine("Enemy is preparing for a strong attack.");
                    break;
            }
        }

        // Bosses - Battle - Turn Method
        public static void enemysMove(Player p1, Boss e1)
        {
            Random rand = new Random();
            switch (rand.Next(4))
            {
                case 0:
                    if (e1.Attack > p1.Defense)
                    {
                        p1.Health -= (e1.Attack - p1.Defense);
                        Console.WriteLine("Enemy dealt {0} damage to Player.", (e1.Attack - p1.Defense));
                    }
                    else
                    {
                        p1.Health -= 1;
                        e1.Health -= 1;
                        Console.WriteLine("Your defense didn't give, but the scrambling hurt you both (1).");
                    }
                    break;
                case 1:
                    e1.Defense++;
                    Console.WriteLine("Enemy is bracing itself against you.");
                    break;
                case 2:
                    e1.Health++;
                    Console.WriteLine("Enemy is licking its wounds.");
                    break;
                case 3:
                    e1.Attack++;
                    Console.WriteLine("Enemy is preparing for a strong attack.");
                    break;
            }
        }

        /** After Battle Stats reset to normal, except health if lower than normal */
        public static void afterBattleStats(int stat1, int stat2, int stat3, int stat4, Player player)
        {
            if (player.Health > stat1)
            {
                player.Health = stat1;
            }
            player.Attack = stat2;
            player.Defense = stat3;
            player.Speed = stat4;
        }

        /** To activate the item scene, call this method */
        public static void itemInterface()
        {
            Console.WriteLine("Item has been spotted.");
            TheUsed soju = new TheUsed();

            // Code to handle the Item Interface Event

            Console.ReadLine();
        }
    }
}
