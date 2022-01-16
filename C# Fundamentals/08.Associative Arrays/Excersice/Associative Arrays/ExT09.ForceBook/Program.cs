using System;
using System.Collections.Generic;
using System.Linq;

namespace ExT09.ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - create new dictionary<string , list<string> // 2 - reading the comands until Lumpawaroo in while loop
            // 3 - splitting the comands between |  and -> // 3.a - when command is | cheking if user exist on the side 
            // then adding the user to the side // 3.b if comand is -> force contains user if not create user for the force 
            // if it contains the user removing form the previous force and adding him to the other force
            // 4 - Printing the result 

            var forceSides = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "Lumpawaroo")
            {
                if (input.Contains("|"))
                {
                    var data = input.Split(" | ");
                    string user = data[1];
                    string side = data[0];
                    if (!forceSides.ContainsKey(side))
                    {
                        forceSides.Add(side, new List<string>());
                    }

                    if (!forceSides[side].Contains(user) && !forceSides.Values.Any(users => users.Contains(user)))
                    {
                        forceSides[side].Add(user);
                    }
                }
                else if (input.Contains("->"))
                {
                    var data = input.Split(" -> ");
                    var user = data[0];
                    var side = data[1];
                    if (!forceSides.Values.Any(users => users.Contains(user)))
                    {
                        if (!forceSides.ContainsKey(side))
                        {
                            forceSides.Add(side, new List<string>());
                        }
                        forceSides[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                    else
                    {
                        foreach (var sides in forceSides.Where(sides => sides.Value.Contains(user)))
                        {
                            sides.Value.Remove(user);
                        }

                        if (!forceSides.ContainsKey(side))
                        {
                            forceSides.Add(side, new List<string>());
                        }
                        forceSides[side].Add(user);
                        Console.WriteLine($"{user} joins the {side} side!");
                    }
                }
                input = Console.ReadLine();
            }

            forceSides = forceSides.OrderByDescending(key => key.Value.Count).ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, u => u.Value);
            foreach (var side in forceSides)
            {
                side.Value.Sort();
                if (side.Value.Count > 0)
                {
                    Console.WriteLine($"Side: {side.Key}, Members: {side.Value.Count}");
                    Console.Write("! ");
                    Console.WriteLine(string.Join("\n! ", side.Value));
                }
            }
        }
    }
}
