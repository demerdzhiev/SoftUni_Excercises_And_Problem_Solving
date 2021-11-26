using System;

namespace T05.BestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();
            string topPlayer = "";
            int topScores = 0;

            while (player != "END")
            {

                int goals =  int.Parse(Console.ReadLine());

                if (goals > topScores)
                {
                    topScores = goals;
                    topPlayer = player;
                }
                if (topScores >= 10)
                {
                    break;
                }
                player = Console.ReadLine();

            }
            Console.WriteLine($"{topPlayer} is the best player!");

            if (topScores >= 3)
            {
                Console.WriteLine($"He has scored {topScores} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {topScores} goals.");
            }

        }
    }
}
