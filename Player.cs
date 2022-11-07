namespace DartGame_Redux_V2
{
    public class Player

    {
        public Player(string name)

        {
            Name = name;
        }
        string Name;

        public string name { get { return Name; } }

        List<Turns> ListOfTurns = new List<Turns>();

        int TotalOfAllRounds;

        public int Totalofrounds { get { return TotalOfAllRounds; } }


        public void CalculatePoints()
        {
            TotalOfAllRounds = 0;
            foreach (Turns Turn in ListOfTurns)

            {
                TotalOfAllRounds += Turn.Get_Score();
                Console.WriteLine($"Score calculated for:{Name}, total score so far:{TotalOfAllRounds}");
            }
        }
        public void Add_Turn()
        {
            Console.WriteLine($"Player is:{Name}");

            if (Name == "Computer Player 1" || Name == "Computer Player 2" || Name == "Computer Player 3")
            {
                int Add_Turn_Toss1;
                int Add_Turn_Toss2;
                int Add_Turn_Toss3;
                Random OurPCRandomThrows = new Random();
                Add_Turn_Toss1 = OurPCRandomThrows.Next(0, 20);
                Add_Turn_Toss2 = OurPCRandomThrows.Next(0, 20);
                Add_Turn_Toss3 = OurPCRandomThrows.Next(0, 20);
                Console.WriteLine($"You threw:{Add_Turn_Toss1} {Add_Turn_Toss2} {Add_Turn_Toss3}");
                ListOfTurns.Add(new Turns(Add_Turn_Toss1, Add_Turn_Toss2, Add_Turn_Toss3));
            }
            else
            {
                int Add_Turn_Toss1;
                int Add_Turn_Toss2;
                int Add_Turn_Toss3;

                do
                {
                    try
                    {
                        Add_Turn_Toss1 = int.Parse(Console.ReadLine());
                    }

                    catch (Exception)
                    {
                        Add_Turn_Toss1 = 21;

                    }
                    if (Add_Turn_Toss1 < 0 || Add_Turn_Toss1 > 20)
                    {
                        Console.WriteLine("Your input needs to be a number between 0 and 20");
                        Console.WriteLine("Try again!");
                    }
                } while (Add_Turn_Toss1 < 0 || Add_Turn_Toss1 > 20);

                do
                {
                    try
                    {
                        Add_Turn_Toss2 = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Add_Turn_Toss2 = 21;
                    }
                    if (Add_Turn_Toss2 < 0 || Add_Turn_Toss2 > 20)
                    {
                        Console.WriteLine("Your input needs to be a number between 0 and 20");
                        Console.WriteLine("Try again!");
                    }

                } while (Add_Turn_Toss2 < 0 || Add_Turn_Toss2 > 20);

                do
                {
                    try
                    {
                        Add_Turn_Toss3 = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Add_Turn_Toss3 = 21;
                    }
                    if (Add_Turn_Toss3 < 0 || Add_Turn_Toss3 > 20)
                    {
                        Console.WriteLine("Your input needs to be a number between 0 and 20");
                        Console.WriteLine("Try again!");
                    }

                    Console.WriteLine($"You threw:{Add_Turn_Toss1} {Add_Turn_Toss2} {Add_Turn_Toss3}");

                } while (Add_Turn_Toss3 < 0 || Add_Turn_Toss3 > 20);

                ListOfTurns.Add(new Turns(Add_Turn_Toss1, Add_Turn_Toss2, Add_Turn_Toss3));
            }
            CalculatePoints();
        }
        public void Print_Turns()
        {
            int NumberOfIteratedRound = 1;
            Console.WriteLine($"This round Belongs to:{Name}");
            foreach (var turn in ListOfTurns)
            {
                Console.WriteLine($"Round Number is:{NumberOfIteratedRound}");
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
