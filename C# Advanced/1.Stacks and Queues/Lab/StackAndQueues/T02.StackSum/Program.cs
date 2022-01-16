using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int[] intArray = input.Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(intArray);
            string command = Console.ReadLine();
            int sum = 0;
            while (command.ToUpper() != "END")
            {
                string[] cmdTokens = command.Split();
                string currCmd = cmdTokens[0];
                if (currCmd.ToUpper() == "ADD")
                {
                    stack.Push(int.Parse(cmdTokens[1]));
                    stack.Push(int.Parse(cmdTokens[2]));
                }
                else if (currCmd.ToUpper() == "REMOVE")
                {
                    if (stack.Count > int.Parse(cmdTokens[1]))
                    {
                        for (int i = 0; i < int.Parse(cmdTokens[1]); i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                command = Console.ReadLine();
            }
            sum = stack.Sum();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
