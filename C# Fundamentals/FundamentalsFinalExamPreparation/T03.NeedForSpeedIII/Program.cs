using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.NeedForSpeedIII
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> cars = new Dictionary<string, List<int>>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //Mercedes CLS|11000|35
                string[] input = Console.ReadLine().Split("|");
                List<int> carData = new List<int>();
                carData.Add(int.Parse(input[1]));
                carData.Add(int.Parse(input[2]));
                cars.Add(input[0], carData);
            }
            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] splittedCommands = command.Split(" : ");
                if (splittedCommands[0] == "Drive")
                {
                    string car = splittedCommands[1];
                    int distance = int.Parse(splittedCommands[2]);
                    int fuel = int.Parse(splittedCommands[3]);
                    List<int> carData = cars[car];
                    if (carData[1] < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[car][0] += distance;
                        cars[car][1] -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        if (cars[car][0] > 100000)
                        {
                            Console.WriteLine($"Time to sell the {car}!");
                            cars.Remove(car);
                        }
                    }
                }
                else if (splittedCommands[0] == "Refuel")
                {
                    string car = splittedCommands[1];
                    int fuel = int.Parse(splittedCommands[2]);
                    int oldFuel = cars[car][1];
                    cars[car][1] += fuel;
                    if (cars[car][1] > 75)
                    {
                        cars[car][1] = 75;
                        Console.WriteLine($"{car} refueled with {75 - oldFuel} liters");
                    }
                    else
                    {
                        Console.WriteLine($"{car} refueled with {fuel} liters");
                    }

                }
                else if (splittedCommands[0] == "Revert")
                {
                    string car = splittedCommands[1];
                    int distance = int.Parse(splittedCommands[2]);

                    cars[car][0] -= distance;
                    if (cars[car][0] < 10000)
                    {
                        cars[car][0] = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {distance} kilometers");
                    }
                }

                command = Console.ReadLine();
            }

            cars = cars.OrderByDescending(c => c.Value[0]).ThenBy(c => c.Key).ToDictionary(k => k.Key, v => v.Value);

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");
            }
        }
    }
}
