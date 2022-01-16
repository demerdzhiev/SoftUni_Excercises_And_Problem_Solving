using System;
using System.Text.RegularExpressions;

namespace T02.AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"([#|])(?<item>[a-zA-z\s]+)(\1)(?<date>[0-9]{2}\/[0-9]{2}\/[0-9]{2})(\1)(?<calories>[0-9]+)(\1)";
            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            int totalCalories = 0;
            foreach (Match match in matches)
            {
                totalCalories += int.Parse(match.Groups["calories"].Value);
            }
            Console.WriteLine($"You have food to last you for: {totalCalories / 2000} days!");
            foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["item"].Value}, Best before: {match.Groups["date"].Value}, Nutrition: {match.Groups["calories"].Value}");
            }
        }
    }
}
