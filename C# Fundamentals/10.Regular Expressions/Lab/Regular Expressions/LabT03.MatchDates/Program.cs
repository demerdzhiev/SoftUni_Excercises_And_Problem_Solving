using System;
using System.Text.RegularExpressions;

namespace LabT03.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\b(?<day>[0-9]{2})([-.\/])(?<monht>[A-Za-z]{3})\1(?<year>[0-9]{4})\b";
            var datesString = Console.ReadLine();
            var dates = Regex.Matches(datesString, regex);
            
            foreach (Match date in dates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["monht"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
