using System;

namespace ExT10.PokeMon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int pokePowerCurrent = pokePower;
            int distanceBetwTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int hitTargets = 0;

            do
            {
                pokePowerCurrent -= distanceBetwTargets;
                hitTargets++;

                if (pokePowerCurrent == pokePower / 2.0 && exhaustionFactor != 0)
                {
                    pokePowerCurrent = pokePowerCurrent / exhaustionFactor;
                }

            } while (pokePowerCurrent >= distanceBetwTargets);

            Console.WriteLine(pokePowerCurrent);
            Console.WriteLine(hitTargets);
        }
    }
}
