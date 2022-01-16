using System;
using System.Text;

namespace T01.WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Travel")
            {
                string[] cmdTokens = command.Split(":");

                if (cmdTokens[0] == "Add Stop")
                {
                    int index = int.Parse(cmdTokens[1]);
                    string stringToAdd = cmdTokens[2];
                    if (index < stops.Length && index >= 0)
                    {
                        stops = stops.Insert(index, stringToAdd);
                    }

                }
                else if (cmdTokens[0] == "Remove Stop")
                {
                    var startIndex = int.Parse(cmdTokens[1]);
                    int endIndex = int.Parse(cmdTokens[2]);
                    if (startIndex < stops.Length && startIndex >= 0 && endIndex < stops.Length && endIndex >= 0)
                    {
                        int count = endIndex - startIndex + 1;
                        stops = stops.Remove(startIndex, count);
                    }
                }
                else if (cmdTokens[0] == "Switch")
                {
                    string substring = cmdTokens[1];
                    string replacement = cmdTokens[2];
                    stops = stops.Replace(substring, replacement);
                }
                Console.WriteLine(stops);
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
