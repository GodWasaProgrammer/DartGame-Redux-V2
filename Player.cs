using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartGame_Redux_V2
{
    public class Player

    {

        public Player(string name)

        {
            Name = name;   
        }
        string Name;

        List<Turns> ListOfTurns = new List<Turns>();
        int TotalOfAllRounds;
        int MyWinningNumber = 301;
        public void CalculatePoints()
        {
            

            foreach (var turn in ListOfTurns) // behöver stoppa att den repeterar på varje iteration av add_turn... men hur
            {
               TotalOfAllRounds += turn.Get_Score();
                Console.WriteLine("Score calculated for:{0}, total score so far:{1}", Name, TotalOfAllRounds);

                if (TotalOfAllRounds == MyWinningNumber || TotalOfAllRounds > MyWinningNumber)
                {
                    Console.WriteLine("We Have a Winner!");
                    Console.WriteLine("The name of the Winner is:{0}", Name);
                    Console.WriteLine("----------- Printing the Rounds of the Winner--------------");
                    Print_Turns();

                    Environment.Exit(0);
                    
                    
                    
                }
            }


            
        }
        
        public void Add_Turn()
        {
           // do { } while (TotalOfAllRounds < MyWinningNumber || TotalOfAllRounds < MyWinningNumber);
            
            Console.WriteLine("Player is:{0}", Name);
                if (Name == "Computer Player 1" || Name == "Computer Player 2" || Name == "Computer Player 3")
                {
                    int Add_Turn_Toss1;
                    int Add_Turn_Toss2;
                    int Add_Turn_Toss3;
                    Random OurPCRandomThrows = new Random();
                    Add_Turn_Toss1 = OurPCRandomThrows.Next(0, 20);
                    Add_Turn_Toss2 = OurPCRandomThrows.Next(0, 20);
                    Add_Turn_Toss3 = OurPCRandomThrows.Next(0, 20);

                    ListOfTurns.Add(new Turns(Add_Turn_Toss1, Add_Turn_Toss2, Add_Turn_Toss3));
                
                }
                else
                {
                    int Add_Turn_Toss1;
                    int Add_Turn_Toss2;
                    int Add_Turn_Toss3;
                    Add_Turn_Toss1 = int.Parse(Console.ReadLine());
                    Add_Turn_Toss2 = int.Parse(Console.ReadLine());
                    Add_Turn_Toss3 = int.Parse(Console.ReadLine());
                

                    ListOfTurns.Add(new Turns(Add_Turn_Toss1, Add_Turn_Toss2, Add_Turn_Toss3));

                }
            
        }

        public void Print_Turns()
        {
            int NumberOfIteratedRound = 1;
            Console.WriteLine("This round Belongs to:{0}", Name);
            
            
            foreach (var turn in ListOfTurns)
            {
                Console.WriteLine("Round Number is:{0}", NumberOfIteratedRound);
                NumberOfIteratedRound++;
                Console.WriteLine(turn);
                


            }
        }

        public override string ToString()
        {
            

            return Name;
        }
    }
}
