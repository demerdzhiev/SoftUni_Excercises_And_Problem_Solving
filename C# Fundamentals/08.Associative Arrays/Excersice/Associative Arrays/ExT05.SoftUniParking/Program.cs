using System;
using System.Collections.Generic;

namespace ExT05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>();
            int numbeOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbeOfCommands; i++)
            {
                var commands = Console.ReadLine().Split();
                var action = commands[0];
                var userName = commands[1];
                switch (action)
                {
                    case "register":
                        var plateNumber = commands[2];
                        if (!users.ContainsKey(userName))
                        {
                            users.Add(userName, plateNumber);
                            Console.WriteLine($"{userName} registered {plateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                        }
                        break;
                    case "unregister":
                        if (!users.ContainsKey(userName))
                        {
                            Console.WriteLine($"ERROR: user {userName} not found");
                        }
                        else
                        {
                            Console.WriteLine($"{userName} unregistered successfully");
                            users.Remove(userName);
                        }
                        break;
                }
            }
            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
