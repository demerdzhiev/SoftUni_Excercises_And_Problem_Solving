//using System;

//namespace T01.FinalExam
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string inputString = Console.ReadLine();
//            string command = Console.ReadLine();
//            while (command != "Done")
//            {
//                string[] cmdTokens = command.Split();
//                string currCmd = cmdTokens[0];
//                if (currCmd == "Change") // Change {char} {replacement}
//                {
//                    string substring = cmdTokens[1];
//                    string replacement = cmdTokens[2];
//                    inputString = inputString.Replace(substring, replacement);
//                    Console.WriteLine(inputString);
//                }
//                else if (currCmd == "Includes") //Includes {otherString}
//                {

//                    bool include = true;
//                    if (!inputString.ToString().Contains(currCmd[1]))
//                    {
//                        include = false;
//                    }
//                    Console.WriteLine(include);
//                }
//                else if (currCmd == "End") // End {otherString}
//                {
//                    bool endswith = true;
//                    if (!inputString.ToString().EndsWith(currCmd[1]))
//                    {
//                        endswith = false;
//                    }
//                    Console.WriteLine(endswith);
//                }
//                else if (currCmd == "Uppercase")
//                {
//                    inputString = inputString.ToUpper();
//                    Console.WriteLine(inputString);
//                }
//                else if (currCmd == "FindIndex") //FindIndex {char}
//                {
//                    int index = inputString.IndexOf(cmdTokens[1]);
//                    Console.WriteLine(index);
//                }
//                else if (currCmd == "Cut") //Cut {startIndex} {length}
//                {
//                    string newString = inputString.Substring(int.Parse(cmdTokens[1]), int.Parse(cmdTokens[2]));
//                    Console.WriteLine(newString);
//                }
//                command = Console.ReadLine();
//            }
//        }
//    }
//}
using System;
using System.Text;

namespace T01.FinalExam
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder(input);
            string commands = Console.ReadLine();

            while (commands != "Done")
            {
                string[] cmd = commands.Split();
                if (cmd[0] == "Change")
                {
                    result.Replace(cmd[1], cmd[2]);
                    Console.WriteLine(result);
                }
                else if (cmd[0] == "Includes")
                {
                    if (result.ToString().Contains(cmd[1]))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (cmd[0] == "End")
                {
                    int lastIndex = result.ToString().LastIndexOf(cmd[1]);
                    int endIndexSubstring = (lastIndex + cmd[1].Length) - 1;
                    if (endIndexSubstring == result.Length - 1)
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (cmd[0] == "Uppercase")
                {
                    for (int i = 0; i < result.Length; i++)
                    {
                        string newChar = result[i].ToString().ToUpper();
                        string old = result[i].ToString();
                        result.Replace(old, newChar);
                    }
                    Console.WriteLine(result);
                }
                else if (cmd[0] == "FindIndex")
                {
                    string crrChar = cmd[1];
                    int index = result.ToString().IndexOf(crrChar);
                    Console.WriteLine(index);
                }
                else if (cmd[0] == "Cut")
                {
                    int startIndex = int.Parse(cmd[1]);
                    int count = int.Parse(cmd[2]);
                    StringBuilder newResult = new StringBuilder();
                    for (int i = startIndex; i < startIndex + count; i++)
                    {
                        newResult.Append(result[i]);
                    }
                    result.Clear();
                    for (int i = 0; i < newResult.Length; i++)
                    {
                        result.Append(newResult[i]);
                    }
                    Console.WriteLine(result);
                }

                commands = Console.ReadLine();
            }
        }
    }
}