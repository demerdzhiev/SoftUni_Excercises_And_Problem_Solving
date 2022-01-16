using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace T05.NetherRealms
{
    class Program
    {
        static void Main(string[] args)
        {
            string healthPattern = @"[^\+\-\*\/\.\,0-9 ]";
            string damgePattern = @"-?\d+\.?\d*";
            string multiplyDividePattern = @"[\*\/]";
            string splitPattern = @"[.\s]+";
            string input = Console.ReadLine();
            string[] demons = Regex.Split(input, splitPattern).OrderBy(x => x).ToArray();
            for (int i = 0; i < demons.Length; i++)
            {
                string curDemon = demons[i];
                MatchCollection helathMatched = Regex.Matches(curDemon, healthPattern);
                long health = 0;
                foreach (Match match in helathMatched)
                {
                    char curChar = char.Parse(match.ToString());
                    health += curChar;
                }

                double damage = 0;
                MatchCollection damageMatched = Regex.Matches(curDemon, damgePattern);
                foreach (Match match in damageMatched)
                {
                    double currentDamage = double.Parse(match.ToString());
                    damage += currentDamage;
                }

                MatchCollection multyplyAndDividers = Regex.Matches(curDemon, multiplyDividePattern);
                foreach (Match multyplyAndDivider in multyplyAndDividers)
                {
                    char currentOperator = char.Parse(multyplyAndDivider.ToString());
                    if (currentOperator == '*')
                    {
                        damage *= 2;
                    }
                    else
                    {
                        damage /= 2;
                    }
                }

                Console.WriteLine($"{curDemon} - {health} health, {damage:f2} damage");
            }
        }
    }
}