using System;
using System.Text.RegularExpressions;

namespace T02.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"([=\/])([A-Z][A-Za-z]{2,})\1");
            string input = Console.ReadLine();
            MatchCollection matches = regex.Matches(input);
            Console.Write($"Destinations: ");
            int index = 0;
            int matchesLength = 0;
            foreach (Match match in matches)
            {
                index++;
                Console.Write($"{match.Groups[2].Value}");
                matchesLength += match.Groups[2].Value.Length;
                if (index < matches.Count)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Travel Points: {matchesLength}");
        }
    }
}
