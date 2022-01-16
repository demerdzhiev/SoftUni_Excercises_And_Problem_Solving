using System;
using System.Linq;

namespace T02.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            string[] rooms = Console.ReadLine().Split("|").ToArray();

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] currCmd = rooms[i].Split();
                string command = currCmd[0];
                int value = int.Parse(currCmd[1]);

                if (command == "potion")
                {
                    int pastHealth = health;
                    int healedPoints = value;
                    health += healedPoints;
                    if (health > 100)
                    {
                        health = 100;
                    }
                    int gainedHealth = health - pastHealth;
                    if (pastHealth == 100)
                    {
                        gainedHealth = 0;
                    }
                    Console.WriteLine($"You healed for {gainedHealth} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (command == "chest")
                {
                    bitcoins += value;
                    Console.WriteLine($"You found {value} bitcoins.");
                }
                else 
                {
                    health -= value;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {command}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                }
            }
            Console.WriteLine($"You've made it!");
            Console.WriteLine($"Bitcoins: {bitcoins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
