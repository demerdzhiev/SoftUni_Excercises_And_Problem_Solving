using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            //string input = Console.ReadLine();
            //string[] tokens = input.Split(" ").ToArray();
            //int index = int.Parse(tokens[1]);


            //while (input != "End")
            //{
            //    string command = tokens[0];

            //    if (command == "Shoot")
            //    {
            //        int value = int.Parse(tokens[2]);

            //        for (int i = 0; i < numbers.Count; i++)
            //        {
            //            if (i == index)
            //            {
            //                numbers[i] -= value;

            //                if (numbers[i] <= 0)
            //                {
            //                    numbers.RemoveAt(i);
            //                }
            //            }
            //        }
            //    }
            //    if (command == "Add")
            //    {


            //        int value = int.Parse(tokens[2]);

            //        for (int i = 0; i < numbers.Count; i++)
            //        {
            //            if (i == index)
            //            {
            //                numbers.Insert(index, value);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Invalid placement!");
            //                break;
            //            }
            //        }
            //    }
            //    if (command == "Strike")
            //    {
            //        int value = int.Parse(tokens[2]);

            //        for (int i = 0; i < numbers.Count; i++)
            //        {
            //            if (i + value > numbers.Count || i - value < 0)
            //            {
            //                Console.WriteLine("Strike missed!");
            //                break;
            //            }
            //            if (index == i)
            //            {
            //                for (int j = 0; j <value ; j++)
            //                {
            //                    numbers.RemoveAt(j);
            //                }
            //                for (int k = value - 1; k >= 0; k--)
            //                {
            //                    numbers.RemoveAt(k);
            //                }
            //            }
            //            else
            //            {
            //                break;
            //            }
            //        }
            //    }
            //    input = Console.ReadLine();
            //}
            //Console.WriteLine(string.Join("|", numbers));

            List<int> targets = Console.ReadLine()
           .Split(" ", StringSplitOptions.RemoveEmptyEntries)
           .Select(int.Parse)
           .ToList();


            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] commandInput = input.Split().ToArray();

                string command = commandInput[0];
                int index = int.Parse(commandInput[1]);

                if (command == "Shoot")
                {
                    int power = int.Parse(commandInput[2]);

                    if (index >= 0 && index < targets.Count)
                    {
                        targets[index] -= power;

                        if (targets[index] <= 0)
                        {
                            targets.RemoveAt(index);
                        }
                    }
                }
                else if (command == "Add")
                {
                    int value = int.Parse(commandInput[2]);

                    if (index >= 0 && index < input.Length)
                    {
                        targets.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }
                else if (command == "Strike")
                {
                    int radius = int.Parse(commandInput[2]);

                    if (index - radius >= 0 && index + radius < targets[targets.Count - 1])
                    {
                        targets.RemoveRange(index - radius, radius * 2 + 1);
                    }
                    else
                    {
                        Console.WriteLine($"Strike missed!");
                    }
                }
            }

            Console.WriteLine(string.Join("|", targets));
        }
    }
}
