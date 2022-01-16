using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace T02._EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(:{2}|\*{2})(?<emojiName>[A-Z][a-z]{2,})\1";
            string digitPattern = @"\d";

            string inputText = Console.ReadLine();

            List<string> coolEmojis = new List<string>();
            long coolThresholdSum = 1;
            int countOfAllEmojis = 0;

            MatchCollection matches = Regex.Matches(inputText, pattern);
            MatchCollection digitMatches = Regex.Matches(inputText, digitPattern);

            foreach (Match digit in digitMatches)
            {
                coolThresholdSum *= int.Parse(digit.Value);
            }

            foreach (Match match in matches)
            {
                string name = match.Groups["emojiName"].Value;
                int sumNameAsDigits = 0;
                countOfAllEmojis++;

                for (int i = 0; i < name.Length; i++)
                {
                    char currentChar = name[i];
                    sumNameAsDigits += currentChar;
                }

                if (sumNameAsDigits > coolThresholdSum)
                {
                    coolEmojis.Add(match.Value);
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine($"Cool threshold: {coolThresholdSum}");
            Console.WriteLine($"{countOfAllEmojis} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join("\n", coolEmojis));
        }
    }
}



//string emojiPattern = @"([:\*]{2})(?<emoji>[A-Z][a-z]{2,})(\1)";
//            string digitPattern = @"(?<digits>\d)";
//            string input = Console.ReadLine();
//            MatchCollection emojiMatches = Regex.Matches(input, emojiPattern);
//            MatchCollection digitMatches = Regex.Matches(input, digitPattern);
//            List<int> digits = new List<int>();
//            Dictionary<string, int> emojis = new Dictionary<string, int>();
//            int threshold = 1;
//            int emojiCounter = 0;
//            int emojiValue = 0;
//            int coolEmojiCounter = 0;
//            foreach (Match match in digitMatches)
//            {
//                threshold *= int.Parse(match.Value);
//            }
            
//            foreach (Match match in emojiMatches)
//            {
//                string emoji = match.Value;
//                emojiCounter++;
//                for (int i = 3; i < match.Length-2; i++)
//                {
//                    emojiValue += 'i';
//                }
//                emojis.Add(match.ToString(), emojiValue);
//            }
//            foreach (var emoji in emojis)
//            {
//                coolEmojiCounter = emojiCounter;
//                if (emojiCounter < threshold)
//                {
//                    emojis.Remove(emoji.ToString());
                    
//                }
//            }
//            emojis = emojis.Take(coolEmojiCounter).OrderBy(x => x.Value).ToDictionary(k =>k.Key, v=>v.Value);
//            Console.WriteLine($"Cool threshold: {threshold}");
//            Console.WriteLine($"{emojiCounter} emojis found in the text. The cool ones are:");
//            foreach (var emoji in emojis)
//            {
//                Console.WriteLine(emoji.Key);
//            }
//        }
//    }
//}


