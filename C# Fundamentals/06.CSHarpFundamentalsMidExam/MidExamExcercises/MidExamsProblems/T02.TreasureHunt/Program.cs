using System;
using System.Collections.Generic;
using System.Linq;

namespace T02.TreasureHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> initialLoot = Console.ReadLine().Split("|").ToList();
            //string command = Console.ReadLine();
            //while (command != "Yohoho!")
            //{
            //    string[] tokens = command.Split(" ");
            //    string currCmd = tokens[0];


            //    if (currCmd == "Loot")
            //    {
            //        for (int i = 0; i < initialLoot.Count; i++)
            //        {
            //            for (int j = 1; j < tokens.Length; j++)
            //            {
            //                if (i != j)
            //                {
            //                    initialLoot.Insert(0, tokens[j]);
            //                }
            //            }
            //        }
            //    }
            //    if (currCmd == "Drop")
            //    {
            //        int currIndex = int.Parse(tokens[1]);
            //        if (currIndex >= 0 && currIndex < initialLoot.Count)
            //        {
            //            for (int i = 0; i < initialLoot.Count; i++)
            //            {
            //                initialLoot.RemoveAt(i);
            //                initialLoot.Add(initialLoot[i]);
            //            }
            //        }
            //    }
            //    if (currCmd == "Steal")
            //    {
            //        int stealCount = int.Parse(tokens[1]);

            //        for (int i = initialLoot.Count - 1; i >= 0; i--)
            //        {
            //            List<string> stealed = new List<string>();
            //            if (i == stealCount)
            //            {
            //                break;
            //            }
            //            else
            //            {

            //                stealed.Add(initialLoot[i]);
            //                initialLoot.RemoveAt(i);
            //            }
            //            Console.WriteLine(string.Join(", ", stealed));
            //        }
            //    }
            //    command = Console.ReadLine();
            //}
            //int sum = 0;
            //int counter = 0;
            //for (int i = 0; i < initialLoot.Count; i++)
            //{
            //    string stealedItem = initialLoot[i];
            //    sum += stealedItem.Length;
            //    counter++;
            //}
            //double averageGain = sum / counter;

            //if (initialLoot.Count > 0)
            //{
            //    Console.WriteLine($"Average treasure gain: {averageGain:f2} pirate credits.");
            //}
            //else
            //{
            //    Console.WriteLine("Failed treasure hunt.");
            //}
            List<string> treasure = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> steal = new List<string>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Yohoho!")
                {
                    break;
                }

                string[] token = command.Split();
                string word = token[0];

                if (word == "Loot")
                {
                    for (int i = 1; i < token.Length; i++)
                    {
                        if (!treasure.Contains(token[i]))
                        {
                            treasure.Insert(0, token[i]);
                        }
                    }
                }

                else if (word == "Drop")
                {
                    int index = int.Parse(token[1]);
                    if (index >= 0 && index < treasure.Count)
                    {
                        string removedItem = treasure[index];
                        treasure.RemoveAt(index);
                        treasure.Add(removedItem);
                    }

                }

                else if (word == "Steal")
                {
                    int count = int.Parse(token[1]);

                    //if (count <= treasure.Count) // Check to see if gives Error in judge !!!
                    if (count < treasure.Count)
                    {
                        for (int i = treasure.Count - count; i < treasure.Count; i++)
                        {
                            steal.Add(treasure[i]);
                        }

                        Console.WriteLine(string.Join(", ", steal));

                        steal.Clear(); // !!! Clear the list

                        treasure.RemoveRange(treasure.Count - count, count);
                    }

                    else
                    {
                        for (int i = 0; i < treasure.Count; i++)
                        {
                            steal.Add(treasure[i]);
                        }
                        Console.WriteLine(string.Join(", ", steal));

                        steal.Clear(); // !!! Clear the list

                        treasure.RemoveRange(0, treasure.Count);
                    }

                }

            }

            double sum = 0;
            double avg = 0;

            foreach (var item in treasure)
            {
                sum = sum + item.Length;
            }


            if (treasure.Count != 0)
            {
                avg = sum / treasure.Count;

                Console.WriteLine($"Average treasure gain: {avg:f2} pirate credits.");
            }

            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }

        }
    }
}
