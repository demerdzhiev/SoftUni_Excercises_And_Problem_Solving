using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.PlantDiscovery
{
    class Plant
    {
        public string plantName;
        public int rarity;
        public List<double> rates = new List<double>();
        public double averageValue = 0;
        public void addRate(double rate)
        {
            averageValue = 0;
            rates.Add(rate);
            for (int i = 0; i < rates.Count; i++)
            {
                averageValue += rates[i];
            }
            averageValue /= rates.Count;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, Plant> dict = new Dictionary<string, Plant>();
            for (int i = 0; i < n; i++)
            {
                string plant = Console.ReadLine();
                string[] plantsPart = plant.Split("<->");
                if (dict.ContainsKey(plantsPart[0]))
                {
                    dict[plantsPart[0]].rarity = int.Parse(plantsPart[1]);
                }
                else
                {
                    Plant currPlant = new Plant();
                    currPlant.plantName = plantsPart[0];
                    currPlant.rarity = int.Parse(plantsPart[1]);
                    dict.Add(plantsPart[0], currPlant);
                }
            }
            string command = Console.ReadLine();
            while (command != "Exhibition")
            {
                string[] values = command.Split();
                if (values[0].Contains("Rate")) // (value[0] == "Rate")
                {
                    if (dict.ContainsKey(values[1]))
                    {
                        dict[values[1]].addRate(double.Parse(values[3]));
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (values[0].Contains("Update"))
                {
                    if (dict.ContainsKey(values[1]))
                    {
                        dict[values[1]].rarity = int.Parse(values[3]);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (values[0].Contains("Reset"))
                {
                    if (dict.ContainsKey(values[1]))
                    {
                        dict[values[1]].rates.Clear();
                        dict[values[1]].averageValue = 0;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in dict.OrderByDescending(x => x.Value.rarity).ThenByDescending(x => x.Value.averageValue))
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.rarity}; Rating: {item.Value.averageValue:f2}");
            }
        }
    }
}
