namespace DartGame_Redux_V2
{
    public class Turns
    {
        int Toss1;
        int Toss2;
        int Toss3;
        int RoundTotal;
        public Turns(int toss1, int toss2, int toss3)
        {
            Toss1 = toss1;
            Toss2 = toss2;
            Toss3 = toss3;
            RoundTotal = toss1 + toss2 + toss3;
        }
        public override string ToString()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("You Threw:{0}", Toss1);
            Console.WriteLine("You Threw:{0}", Toss2);
            Console.WriteLine("You Threw:{0}", Toss3);
            Console.WriteLine("Your RoundTotal is:{0}", RoundTotal);
            Console.WriteLine("-------------------------------");

            return null;

        }
        public int Get_Score()
        {
            return RoundTotal;
        }
    }
}
