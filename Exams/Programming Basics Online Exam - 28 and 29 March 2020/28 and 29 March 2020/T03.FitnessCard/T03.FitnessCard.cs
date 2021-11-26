using System;

namespace T03.FitnessCard
{
    class Program
    {
        static void Main(string[] args)
        {
            int moneyWeHave = int.Parse(Console.ReadLine());
            string sex = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            double tax = 0;

            switch (sport)
            {
                case "Gym":
                    if (sex == "m")
                    {
                        tax = 42;
                    }
                    else if (sex == "f")
                    {
                        tax = 35;
                    }
                    break;
                case "Boxing":
                    if (sex == "m")
                    {
                        tax = 41;
                    }
                    else if (sex == "f")
                    {
                        tax = 37;
                    }
                    break;
                case "Yoga":
                    if (sex == "m")
                    {
                        tax = 45;
                    }
                    else if (sex == "f")
                    {
                        tax = 42;
                    }
                    break;
                case "Zumba":
                    if (sex == "m")
                    {
                        tax = 34;
                    }
                    else if (sex == "f")
                    {
                        tax = 31;
                    }
                    break;
                case "Dances":
                    if (sex == "m")
                    {
                        tax = 51;
                    }
                    else if (sex == "f")
                    {
                        tax = 53;
                    }
                    break;
                case "Pilates":
                    if (sex == "m")
                    {
                        tax = 39;
                    }
                    else if (sex == "f")
                    {
                        tax = 37;
                    }
                    break;

            }
            if (age <= 19)
            {
                tax *= 0.8;
            }

            if (moneyWeHave >= tax)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${tax - moneyWeHave:f2} more.");
            }
        }
    }
}
