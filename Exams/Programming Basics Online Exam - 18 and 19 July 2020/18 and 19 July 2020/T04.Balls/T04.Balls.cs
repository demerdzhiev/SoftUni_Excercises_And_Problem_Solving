using System;

namespace T04.Balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBalls = int.Parse(Console.ReadLine());
            int totalPoints = 0;
            int redBalls = 0;
            int orangeBalls = 0;
            int yellowBalls = 0;
            int whiteBalls = 0;
            int othersBalls = 0;
            int blackBalls = 0;
            string lastColor = "";

            for (int i = 0; i < numberOfBalls; i++)
            {
                string color = Console.ReadLine();

                if (color == "red")
                {
                    totalPoints += 5;
                    redBalls++;
                }
                else if (color == "orange")
                {
                    totalPoints += 10;
                    orangeBalls++;
                }
                else if (color == "yellow")
                {
                    yellowBalls++;
                    totalPoints += 15;
                    
                }
                else if (color == "white")
                {
                    whiteBalls++;
                    totalPoints += 20;
                }
                else if (color == "black")
                {
                    blackBalls++;
                    totalPoints /= 2;
                }
                else 
                {
                    othersBalls++;
                }

                lastColor = color;
            }
            Console.WriteLine($"Total points: {totalPoints}");
            Console.WriteLine($"Points from red balls: {redBalls}");
            Console.WriteLine($"Points from orange balls: {orangeBalls}");
            Console.WriteLine($"Points from yellow balls: {yellowBalls}");
            Console.WriteLine($"Points from white balls: {whiteBalls}");
            Console.WriteLine($"Other colors picked: {othersBalls}");
            Console.WriteLine($"Divides from black balls: {blackBalls}");
        }
    }
}
