using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T04._Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesNumber = int.Parse(Console.ReadLine());
            string regex =
                @"@(?<name>[A-z]+)[^@\-!:>]*:(?<population>[\d+]+)[^@\-!:>]*!(?<type>[A,D])![^@\-!:>]*->(?<count>[\d]+)";
            List<string> attacked = new List<string>();
            List<string> destroyed = new List<string>();
            for (int i = 0; i < linesNumber; i++)
            {
                string messages = Console.ReadLine();
                int sum = messages.ToLower().Count(x => x == 's' || x == 't' || x == 'a' || x == 'r');
                string decryptedMessage = "";
                foreach (char charType in messages)
                {
                    decryptedMessage += (char)(charType - sum);
                }

                Match matchs = Regex.Match(decryptedMessage, regex, RegexOptions.IgnoreCase);
                if (matchs.Success)
                {
                    string name = matchs.Groups["name"].Value;
                    int population = int.Parse(matchs.Groups["population"].Value);
                    char type = char.Parse(matchs.Groups["type"].Value);
                    int soldiersCount = int.Parse(matchs.Groups["count"].Value);

                    if (type != 'A') destroyed.Add(name);
                    else attacked.Add(name);
                }
            }

            Console.WriteLine($"Attacked planets: {attacked.Count}");
            attacked.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            destroyed.OrderBy(x => x).ToList().ForEach(planetName => Console.WriteLine($"-> {planetName}"));
        }
    }
}