using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - Create: dic legendaryItems, dic junks // 2 - create bool isLegendaryFound = false 
            // 3 - for loop through inputs i+= 2 [3, 'Motes"] keyMaterials[i], valueNumber[i -1]
            // 4 - if keyMaterials == shards || motes || fragments // 5 - legendaryItems[keyMaterials] += valueNumber
            // 6 - legendaryItems[keyMaterials] >= 250 => isLegendaryFound = true break loop  and print the cur legendary item // 7 - isLegendaryFound is not found, keep looping through // 8 -> after printing the isLegendaryFound
            // prinitng all the materials in some order

            var legendaryItems = new Dictionary<string, int>();
            legendaryItems.Add("shards", 0);
            legendaryItems.Add("motes", 0);
            legendaryItems.Add("fragments", 0);
            var junkMaterials = new Dictionary<string, int>();
            bool isLegendaryFound = false;
            while (!isLegendaryFound)
            {
                string[] input = Console.ReadLine().Split();
                for (int i = 1; i < input.Length; i += 2)
                {
                    string keyMaterial = input[i].ToLower(); // shards
                    int valueMaterial = int.Parse(input[i - 1]); // 10
                    if (keyMaterial == "shards" || keyMaterial == "motes" || keyMaterial == "fragments")
                    {
                        legendaryItems[keyMaterial] += valueMaterial;
                        if (legendaryItems[keyMaterial] >= 250)
                        {
                            isLegendaryFound = true;
                            break;
                        }
                    }
                    else if (junkMaterials.ContainsKey(keyMaterial))
                    {
                        junkMaterials[keyMaterial] += valueMaterial;
                    }
                    else
                    {
                        junkMaterials.Add(keyMaterial, valueMaterial);
                    }
                }
            }

            if (legendaryItems["shards"] >= 250)
            {
                Console.WriteLine("Shadowmourne obtained!");
                legendaryItems["shards"] -= 250;
            }
            else if (legendaryItems["fragments"] >= 250)
            {
                Console.WriteLine("Valanyr obtained!");
                legendaryItems["fragments"] -= 250;
            }
            else if (legendaryItems["motes"] >= 250)
            {
                Console.WriteLine("Dragonwrath obtained!");
                legendaryItems["motes"] -= 250;
            }

            foreach (var keyItem in legendaryItems.OrderByDescending(key => key.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{keyItem.Key}: {keyItem.Value}");
            }

            foreach (var junkItem in junkMaterials.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{junkItem.Key}: {junkItem.Value}");
            }
        }
    }
}
