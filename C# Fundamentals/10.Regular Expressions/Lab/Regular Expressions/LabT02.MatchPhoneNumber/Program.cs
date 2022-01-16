using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace LabT02.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //var regex = @"\S?[+][0-9]{3}(\.|-| )[0-9]{1}\1[0-9]{3}\1[0-9]{4}\b";
            //var phones = Console.ReadLine();
            //var phoneMatches = Regex.Matches(phones, regex);
            //var matchedPhones = phoneMatches.Cast<Match>().Select(a => a.Value.Trim()).ToArray();
            //Console.WriteLine(string.Join(", ", matchedPhones));
            string pattern = @"\+([359]+)([- ])2(\2)(\d{3})(\2)(\d{4})\b";
            string phonesInputs = Console.ReadLine();
            Regex phonePatternex = new Regex(pattern);
            var match = phonePatternex.Matches(phonesInputs);
            int phoneNumbersCount = 0;

            foreach (var phoneNumber in match)
            {
                string collection = phoneNumber + ", ";
                phoneNumbersCount += 1;
                if (phoneNumbersCount == match.Count)
                {
                    Console.Write(collection.Remove(collection.Length - 2));
                }
                else
                {
                    Console.Write(collection);
                }
            }
            Console.WriteLine();
        }
    }
}
