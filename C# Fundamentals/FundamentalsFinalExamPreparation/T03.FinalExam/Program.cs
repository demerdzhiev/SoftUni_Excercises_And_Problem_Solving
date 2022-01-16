using System;
using System.Collections.Generic;
using System.Linq;

namespace Т03.FinalExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var guests = new Dictionary<string, List<string>>();
            int counter = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Stop")
                {
                    break;
                }
                string[] commandSplitted = command.Split('-');
                string LikeOrDislike = commandSplitted[0];
                string guest = commandSplitted[1];
                string meal = commandSplitted[2];

                if (LikeOrDislike == "Like")
                {
                    if (!guests.ContainsKey(guest))
                    {
                        guests.Add(guest, new List<string>());
                        guests[guest].Add(meal);
                    }
                    else
                    {
                        if (!guests[guest].Contains(meal))
                        {
                            guests[guest].Add(meal);
                        }
                    }
                }
                else if (LikeOrDislike == "Dislike")
                {
                    if (guests.ContainsKey(guest))
                    {
                        if (guests[guest].Contains(meal))
                        {
                            guests[guest].Remove(meal);
                            counter++;
                            Console.WriteLine($"{guest} doesn't like the {meal}.");
                        }
                        else
                        {
                            Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"{guest} is not at the party.");
                    }
                }

            }
            foreach (var (guest, listOfMeals) in guests.OrderByDescending(x => x.Value.Count).ThenBy(y => y.Key))
            {
                Console.WriteLine($"{guest}: {string.Join(", ", listOfMeals)}");
            }
            Console.WriteLine($"Unliked meals: {counter}");
        }
    }
}