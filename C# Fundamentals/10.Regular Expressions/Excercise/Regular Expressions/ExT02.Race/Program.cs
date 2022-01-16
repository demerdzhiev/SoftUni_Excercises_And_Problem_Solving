using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ExT02.Race
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex patternForName = new Regex(@"(?<name>[A-Za-z]+)"); // Pattern for finding the name
            string patternForDigits = @"(?<digits>\d+)"; // Pattern for finding the digit
            int sumOfDigits = 0;

            // Dictionary for the participant
            Dictionary<string, int> participants = new Dictionary<string, int>();

            // input of => List of participants name
            List<string> names = Console.ReadLine().Split(", ").ToList();

            // Reading the input after the names:
            string input = Console.ReadLine();

            // Main logic 
            while (input != "end of race")
            {
                MatchCollection matchedNames = patternForName.Matches(input); // Finding the name(words) in array
                MatchCollection matchedDigits = Regex.Matches(input, patternForDigits);  // Finding the digits 
                string currName = string.Join("", matchedNames); // joing the words
                string currDigit = string.Join("", matchedDigits); // joing the digits

                sumOfDigits = 0;
                for (int i = 0; i < currDigit.Length; i++)
                {
                    //Convert currentDigit into integer value
                    sumOfDigits += int.Parse(currDigit[i].ToString());
                }

                // make a check if the current participant name exist in the list of names
                if (names.Contains(currName))
                {
                    // check if the participant name is not existent in the dictionary
                    if (!participants.ContainsKey(currName))
                    {
                        // We are adding the current name and sum of digits
                        participants.Add(currName, sumOfDigits);
                    }
                    else
                    {
                        // We are adding the sum of the current digits towards the sum he already got
                        participants[currName] += sumOfDigits;
                    }
                }

                input = Console.ReadLine();
            }

            // Finding the winners
            var winners = participants.OrderByDescending(x => x.Value).Take(3);
            // Find the first place
            var firstPlace = winners.Take(1);
            var secondPlace = winners.OrderByDescending(x => x.Value).Take(2).OrderBy(x => x.Value).Take(1);
            var thirdPlace = winners.OrderBy(x => x.Value).Take(1);
            foreach (var firstName in firstPlace)
            {
                Console.WriteLine($"1st place: {firstName.Key}");
            }
            foreach (var secondName in secondPlace)
            {
                Console.WriteLine($"2nd place: {secondName.Key}");
            }
            foreach (var thirdPairName in thirdPlace)
            {
                Console.WriteLine($"3rd place: {thirdPairName.Key}");
            }
        }
    }
}
