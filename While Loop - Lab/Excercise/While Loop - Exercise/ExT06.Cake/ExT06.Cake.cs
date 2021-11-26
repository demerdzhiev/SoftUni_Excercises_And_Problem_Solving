using System;

namespace ExT06.Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int totalPieces = width * lenght;
            

            while (totalPieces > 0)
            {
                string input = Console.ReadLine();
                

                if (input == "STOP")
                {
                    break;
                }

                int pieces = int.Parse(input);
                totalPieces -= pieces;
            }
            if (totalPieces >= 0)
            {
                Console.WriteLine($"{totalPieces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPieces)} pieces more.");
            } 
        }
        
    }

   
}
