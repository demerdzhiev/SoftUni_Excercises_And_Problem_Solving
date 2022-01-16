using System;
using System.Text.RegularExpressions;

namespace LabT01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();

            MatchCollection matchednames = Regex.Matches(names, regex);
            foreach (Match name in matchednames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
