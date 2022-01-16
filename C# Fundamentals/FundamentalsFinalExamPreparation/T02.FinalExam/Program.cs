//using System;
//using System.Text;
//using System.Text.RegularExpressions;

//namespace T02.FinalExam
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string pattern = @"^([$]|[%])(?<tag>[A-Z][a-z]{2,})(\1): [(?<group1>[0-9]+)]|[(?<group2>[0-9]+)]|[(?<group3>[0-9]+)]|$";
//            int numberOfINputs = int.Parse(Console.ReadLine());
//            StringBuilder decryptedMassage = new StringBuilder();
//            for (int i = 0; i < numberOfINputs; i++)
//            {
//                string input = Console.ReadLine();
//                MatchCollection matches = Regex.Matches(input, pattern);

//                foreach (Match match in matches)
//                {
//                    string tag = match.Groups["tag"].Value;
//                    int number1 = int.Parse(match.Groups["group1"].Value);
//                    int number2 = int.Parse(match.Groups["group2"].Value);
//                    int number3 = int.Parse(match.Groups["group3"].Value);


//                    char dec1 = (char)number1;
//                    char dec2 = (char)number1;
//                    char dec3 = (char)number1;

//                    decryptedMassage.Insert(0, dec3);
//                    decryptedMassage.Insert(0, dec2);
//                    decryptedMassage.Insert(0, dec1);
//                    Console.WriteLine($"{tag}: {decryptedMassage}");
//                }




//            }
//        }
//    }
//}


//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text.RegularExpressions;

//namespace ConsoleApp3
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            string patternTag = @"^([$]|[%])(?<tag>[A-Z][a-z]{2,})(\1): [(?<code1>[0-9]+)]|[(?<code2>[0-9]+)]|[(?<code3>[0-9]+)]|$";
//            int num = int.Parse(Console.ReadLine());
//            for (int i = 0; i < num; i++)
//            {
//                string[] input = Console.ReadLine().Split(": ").ToArray();
//                Regex rgx = new Regex(patternTag);
//                bool isTag = rgx.IsMatch(input[0]);
//                string word = string.Empty;

//                if (isTag)
//                {

//                    char[] separatops = new char[] { '[', ']', '|' };
//                    int[] nums = input[1].Split(separatops, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
//                    for (int j = 0; j < nums.Length; j++)
//                    {
//                        char ch = Convert.ToChar(nums[j]);
//                        word += ch;
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Valid message not found!");
//                }
//                string tagg = input[0];
//                tagg.Remove(tagg.Length - 1);
//                tagg.Remove(0);
//                Console.WriteLine($"{tagg}:{word}");
//            }



//        }
//    }
//}



using System;
using System.Text.RegularExpressions;

namespace MessageDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"^([$%])([A-Z][a-z]{2,})([$%])\:\s\[(\d+)\]\|\[(\d+)\]\|\[(\d+)\]\|$";


            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = Regex.Match(input, pattern);

                if (match.Success)
                {
                    string openningTag = match.Groups[1].Value;
                    string closingTag = match.Groups[3].Value;

                    if (openningTag == closingTag)
                    {
                        string nameTag = match.Groups[2].Value;
                        string message = string.Empty;

                        for (int j = 4; j < match.Groups.Count; j++)
                        {
                            int val = int.Parse(match.Groups[j].Value);
                            if (val > 255)
                            {
                                Console.WriteLine("Valid message not found!");
                                continue;
                            }
                            message += (char)val;
                        }
                        Console.WriteLine($"{nameTag}: {message}");
                    }
                    else
                    {
                        Console.WriteLine("Valid message not found!");
                    }
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}