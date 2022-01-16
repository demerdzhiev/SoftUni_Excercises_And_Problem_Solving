using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.HeroesOfCodeAndLogicVII
{
    class Hero
    {
        public int HP { get; set; }
        public int MP { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(); // {hero name} {HP} {MP}
                heroes.Add(input[0], new Hero()
                {
                    HP = int.Parse(input[1]),
                    MP = int.Parse(input[2]),
                });
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                string[] cmdTokens = command.Split(" - ");
                string currCmd = cmdTokens[0];
                if (currCmd == "CastSpell") // CastSpell – {hero name} – {MP needed} – {spell name}
                {
                    string heroName = cmdTokens[1];
                    int MPneeded = int.Parse(cmdTokens[2]);
                    string spellName = cmdTokens[3];

                    if (MPneeded <= heroes[heroName].MP)
                    {
                        heroes[heroName].MP -= MPneeded;
                        Console.WriteLine($"{heroName} has successfully cast {spellName} and now has {heroes[heroName].MP} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heroName} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (currCmd == "TakeDamage") // TakeDamage – {hero name} – {damage} – {attacker}"
                {
                    string heroName = cmdTokens[1];
                    int damage = int.Parse(cmdTokens[2]);
                    string attacker = cmdTokens[3];
                    heroes[heroName].HP -= damage;
                    if (heroes[heroName].HP > 0)
                    {
                        Console.WriteLine($"{heroName} was hit for {damage} HP by {attacker} and now has {heroes[heroName].HP} HP left!");
                    }
                    else
                    {
                        heroes.Remove(heroName);
                        Console.WriteLine($"{heroName} has been killed by {attacker}!");
                    }
                }
                else if (currCmd == "Recharge") //Recharge – { hero name} – { amount}
                {
                    string heroName = cmdTokens[1];
                    int amount = int.Parse(cmdTokens[2]);
                    int firstMPValue = heroes[heroName].MP;
                    heroes[heroName].MP += amount;
                    if (heroes[heroName].MP > 200)
                    {
                        heroes[heroName].MP = 200;
                    }
                    int rechargedMP = heroes[heroName].MP - firstMPValue;
                    Console.WriteLine($"{heroName} recharged for {rechargedMP} MP!");
                }
                else if (currCmd == "Heal") // Heal – {hero name} – {amount}
                {
                    string heroName = cmdTokens[1];
                    int amount = int.Parse(cmdTokens[2]);
                    int firstHPValue = heroes[heroName].HP;
                    heroes[heroName].HP += amount;
                    if (heroes[heroName].HP > 100)
                    {
                        heroes[heroName].HP = 100;
                    }
                    int rechargedHP = heroes[heroName].HP - firstHPValue;
                    Console.WriteLine($"{heroName} healed for {rechargedHP} HP!");
                }
                command = Console.ReadLine();
            }
            heroes = heroes.OrderByDescending(h => h.Value.HP).ThenBy(n => n.Key).ToDictionary(k => k.Key, v => v.Value);
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value.HP}");
                Console.WriteLine($"  MP: {hero.Value.MP}");
                
            }
        }
    }
}
