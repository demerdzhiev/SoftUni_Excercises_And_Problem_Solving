using System;

namespace ExT10.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] ladyBugField = new int[fieldSize];

            string[] occupiedIndexes = Console.ReadLine().Split();
            foreach (var ladyBugs in occupiedIndexes)
            {
                int currentIndex = int.Parse(ladyBugs);
                if (currentIndex >= 0 && currentIndex < fieldSize)
                {
                    ladyBugField[currentIndex] = 1;
                }
            }
            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                int currentIndex = int.Parse(commands[0]);
                bool isFirst = true;
                while (currentIndex >= 0 && currentIndex < fieldSize && ladyBugField[currentIndex] != 0) 
                {
                    if (isFirst)
                    {
                        ladyBugField[currentIndex] = 0;
                        isFirst = false;
                    }
                    string direction = commands[1];
                    int flightLength = int.Parse(commands[2]);
                    if (direction == "left")
                    {
                        currentIndex -= flightLength;
                        if (currentIndex >= 0 && currentIndex < fieldSize)
                        {
                            if (ladyBugField[currentIndex] == 0)
                            {
                                ladyBugField[currentIndex] = 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        currentIndex += flightLength;
                        if (currentIndex >= 0 && currentIndex < fieldSize)
                        {
                            if (ladyBugField[currentIndex] == 0)
                            {
                                ladyBugField[currentIndex] = 1;
                                break;
                            }
                            
                        }
                    }
                }
                commands = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", ladyBugField));
        }
    }
}
