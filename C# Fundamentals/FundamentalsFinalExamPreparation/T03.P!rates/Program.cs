using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.P_rates
{
    class City
    {
        public int CityPopulation { get; set; }
        public int CityGold { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, City> cities = new Dictionary<string, City>();
            while (input != "Sail")
            {
                string[] inputTokens = input.Split("||"); //Tortuga||345000||1250

                if (!cities.ContainsKey(inputTokens[0]))
                {
                    cities.Add(inputTokens[0], new City()
                    {
                        CityPopulation = int.Parse(inputTokens[1]),
                        CityGold = int.Parse(inputTokens[2]),
                    });
                }
                else
                {
                    cities[inputTokens[0]].CityPopulation += int.Parse(inputTokens[1]);
                    cities[inputTokens[0]].CityGold += int.Parse(inputTokens[2]);
                }
                input = Console.ReadLine();
            }
            string currEvent = Console.ReadLine();
            while (currEvent != "End")
            {
                string[] cmdTokens = currEvent.Split("=>");
                string currCmd = cmdTokens[0];
                string currCity = cmdTokens[1];
                if (currCmd == "Plunder") // Plunder=>{town}=>{people}=>{gold}
                {
                    cities[currCity].CityPopulation -= int.Parse(cmdTokens[2]);
                    cities[currCity].CityGold -= int.Parse(cmdTokens[3]);
                    Console.WriteLine($"{currCity} plundered! {cmdTokens[3]} gold stolen, {cmdTokens[2]} citizens killed.");
                    if (cities[currCity].CityPopulation <= 0 || cities[currCity].CityGold <= 0)
                    {
                        Console.WriteLine($"{currCity} has been wiped off the map!");
                        cities.Remove(currCity);
                    }
                }
                else if (currCmd == "Prosper") // Prosper=>{town}=>{gold}
                {
                    if (int.Parse(cmdTokens[2]) < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        break;
                    }
                    else
                    {
                        cities[currCity].CityGold += int.Parse(cmdTokens[2]);
                        Console.WriteLine($"{cmdTokens[2]} gold added to the city treasury. {currCity} now has {cities[currCity].CityGold} gold.");
                    }
                }
                currEvent = Console.ReadLine();
            }
            Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
            cities = cities.OrderByDescending(g => g.Value.CityGold).ThenBy(n => n.Key).ToDictionary(k => k.Key, v => v.Value);
            foreach (var city in cities)
            {
                Console.WriteLine($"{city.Key} -> Population: {city.Value.CityPopulation} citizens, Gold: {city.Value.CityGold} kg");
            }
        }
    }
}
