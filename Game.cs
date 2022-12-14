using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DartGame_Redux_V2
{
    public class Game
    {
        List<Player> Gamers = new List<Player>();
        string name;
        int GameLoop = 0;
        int NumberToWin = 301;
        
        public void PlayGame()
        {
            Console.WriteLine("Dart Game");
            do
            {
                Console.WriteLine("Choose your Player name");
                Console.WriteLine("if no choice is made, player will be PC");
                name = Console.ReadLine();
                if (name == "" || name == null)
                {
                    name = "Computer Player 1";
                    if (Gamers.Count == 1)
                    {
                        name = "Computer Player 2";
                    }

                    if (Gamers.Count == 2)
                    {
                        name = "Computer Player 3";
                    }

                }
                Gamers.Add(new Player(name));

            } while (Gamers.Count < 3);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("All Players Added. Game Commencing");
            do
                foreach (Player player in Gamers)
                {
                    
                        player.Add_Turn();
                        

                    if (player.Totalofrounds > NumberToWin)
                    {
                        Console.WriteLine("We Have a Winner!");
                        Console.WriteLine($"The name of the Winner is:{player.name}");
                        Console.WriteLine("----------- Printing the Rounds of the Winner--------------");
                        player.Print_Turns();
                        Environment.Exit(0);
                    }
                    if (player.Totalofrounds == NumberToWin)
                    {
                        Console.WriteLine("We Have a Winner!");
                        Console.WriteLine($"The name of the Winner is:{player.name}");
                        Console.WriteLine("----------- Printing the Rounds of the Winner--------------");
                        player.Print_Turns();
                         Environment.Exit(0);
                    }
                    } while (GameLoop != 1);
        }
        }
}
