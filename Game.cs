using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DartGame_Redux_V2
{
    public class Game
    {
        List<Player> Gamers = new List<Player>();
        List <int> Rounds = new List<int>();
        string ?name;
        int GameLoop = 0;
        
        public void GameLoopController()
        {
            GameLoop = 1;
            
            
        }
        
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
                    if (Gamers.Count == 1 )
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

            //Console.WriteLine("Printing our Player List");
            Console.ForegroundColor = ConsoleColor.Green;

            //foreach (Player player in Gamers) // just to see whats in our field
            //{
            //    Console.WriteLine("---------------------------------------");
                
            //    Console.WriteLine(player);
            //}

            Console.WriteLine("All Players Added. Game Commencing");


            
                do
                    foreach (Player player in Gamers)

                    {

                        player.Add_Turn();
                        player.CalculatePoints();


                        

                    } while (GameLoop != 1);

                


            // foreach (Player player in Gamers)
            // {
            //    player.Print_Turns();
            // }




        }


        }
}
