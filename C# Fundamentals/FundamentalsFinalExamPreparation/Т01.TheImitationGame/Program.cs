using System;
using System.Text;

namespace Т01.TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder(input);
            string command = Console.ReadLine();
            while (command != "Decode")
            {
                string[] splittedCommands = command.Split("|");
                if (splittedCommands[0] == "ChangeAll")
                {
                    result.Replace(splittedCommands[1], splittedCommands[2]);
                }
                else if (splittedCommands[0] == "Insert")
                {
                    int index = int.Parse(splittedCommands[1]);
                    string value = splittedCommands[2];
                    result.Insert(index, value);
                }
                else if (splittedCommands[0] == "Move")
                {
                    int number = int.Parse(splittedCommands[1]);
                    string substring = result.ToString().Substring(0, number);
                    result.Remove(0, number);
                    result.Append(substring);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"The decrypted message is: {result}");
        }
    }
}
