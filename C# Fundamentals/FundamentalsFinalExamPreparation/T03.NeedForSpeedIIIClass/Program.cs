using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.NeedForSpeedIII
{
    class Car
    {
        public int Mileage { get; set; }

        public int Fuel { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                //Mercedes CLS|11000|35
                string[] input = Console.ReadLine().Split("|");
                cars.Add(input[0], new Car()
                {
                    Mileage = int.Parse(input[1]),
                    Fuel = int.Parse(input[2])
                });
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
                    Car carData = cars[car];
                    if (carData.Fuel < fuel)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        cars[car].Mileage += distance;
                        cars[car].Fuel -= fuel;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        if (cars[car].Mileage > 100000)
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
                    int oldFuel = cars[car].Fuel;
                    cars[car].Fuel += fuel;
                    if (cars[car].Fuel > 75)
                    {
                        cars[car].Fuel = 75;
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

                    cars[car].Mileage -= distance;
                    if (cars[car].Mileage < 10000)
                    {
                        cars[car].Mileage = 10000;
                    }
                    else
                    {
                        Console.WriteLine($"{car} mileage decreased by {distance} kilometers");
                    }
                }

                command = Console.ReadLine();
            }


            cars = cars.OrderByDescending(c => c.Value.Mileage).ThenBy(c => c.Key).ToDictionary(k => k.Key, v => v.Value);

            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value.Mileage} kms, Fuel in the tank: {car.Value.Fuel} lt.");
            }
        }
    }
}
