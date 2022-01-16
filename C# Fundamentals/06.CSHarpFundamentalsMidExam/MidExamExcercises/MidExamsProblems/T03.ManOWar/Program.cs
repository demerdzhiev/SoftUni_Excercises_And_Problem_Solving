using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.ManOWar
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> pirateShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            List<int> warShip = Console.ReadLine().Split(">").Select(int.Parse).ToList();
            int maxHealthCap = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();

            while (command != "Retire")
            {
                string[] tokens = command.Split().ToArray();
                string currCmd = tokens[0];

                if (currCmd == "Fire")
                {
                    int currIndex = int.Parse(tokens[1]);
                    int currDamage = int.Parse(tokens[2]);

                    for (int i = 0; i < warShip.Count; i++)
                    {
                        if (currIndex < 0 && currIndex >= warShip.Count)
                        {
                            break;
                        }
                        else
                        {
                            if (currIndex == i)
                            {
                                warShip[i] -= currDamage;
                            }
                            if (warShip[i] <= 0)
                            {
                                Console.WriteLine("You won! The enemy ship has sunken.");
                                return;
                            }
                        }
                    }
                }
                if (currCmd == "Defend")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int endIndex = int.Parse(tokens[2]);
                    int currDamage = int.Parse(tokens[3]);

                    if (startIndex >= 0 && startIndex < pirateShip.Count && endIndex >= 0 && endIndex < pirateShip.Count)

                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            pirateShip[i] -= currDamage;

                            if (pirateShip[i] <= 0)
                            {
                                Console.WriteLine("You lost! The pirate ship has sunken.");
                                return;
                            }
                        }


                }
                if (currCmd == "Repair")
                {
                    int currIndex = int.Parse(tokens[1]);
                    int givenHealth = int.Parse(tokens[2]);

                    if (currIndex < 0 && currIndex >= pirateShip.Count)
                    {
                        break;
                    }
                    else
                    {
                        for (int i = 0; i < pirateShip.Count; i++)
                        {
                            if (currIndex == i)
                            {
                                pirateShip[i] += givenHealth;
                                if (pirateShip[i] > maxHealthCap)
                                {
                                    pirateShip[i] = maxHealthCap;
                                }
                            }
                        }
                    }
                }
                if (currCmd == "Status")
                {
                    int repairCounter = 0;

                    for (int i = 0; i < pirateShip.Count; i++)
                    {
                        if (pirateShip[i] < maxHealthCap * 0.2)
                        {
                            repairCounter++;
                        }
                    }
                    Console.WriteLine($"{repairCounter} sections need repair.");
                }

                command = Console.ReadLine();
            }
            int pirateShipStatus = pirateShip.Sum();
            int warShipStatus = warShip.Sum();
            Console.WriteLine($"Pirate ship status: {pirateShipStatus}");
            Console.WriteLine($" Warship status: {warShipStatus}");


        }
    }
}
