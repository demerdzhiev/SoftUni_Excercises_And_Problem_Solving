using System;

namespace EXT04.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            const int GOAL = 10000;
            int totaSteps = 0;
            while (totaSteps < GOAL)
            {
                string input = Console.ReadLine();

                if (input == "Going home")
                {
                    int stepsLeft = int.Parse(Console.ReadLine());
                    totaSteps += stepsLeft;
                    break;
                }
                int steps = int.Parse(input);
                totaSteps += steps;
            }
            if (totaSteps >= GOAL)
            {
                Console.WriteLine("Goal reached! Good job!");
                int stepsOver = totaSteps - GOAL;
                Console.WriteLine($"{stepsOver} steps over the goal!");
            }
            else
            {
                int difference = GOAL - totaSteps;
                Console.WriteLine($"{difference} more steps to reach goal.");  
            }


        }
    }
}
