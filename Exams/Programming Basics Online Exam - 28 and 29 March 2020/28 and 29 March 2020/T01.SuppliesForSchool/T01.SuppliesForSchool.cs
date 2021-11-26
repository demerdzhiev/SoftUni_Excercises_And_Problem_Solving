using System;

namespace T01.SuppliesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int packsOfPens = int.Parse(Console.ReadLine());
            int packsOfMarkers = int.Parse(Console.ReadLine());
            double litersOfDetergent = double.Parse(Console.ReadLine());
            double discount = double.Parse(Console.ReadLine());

            double priceOfPackOfPens = 5.80;
            double priceOfPackOfMarkers = 7.20;
            double priceOfLitersOfDetergent = 1.20;

            double expences = ((packsOfPens * priceOfPackOfPens) + (packsOfMarkers * priceOfPackOfMarkers) + (litersOfDetergent * priceOfLitersOfDetergent));
            double afterDiscount = expences - (expences * discount / 100);

            Console.WriteLine($"{afterDiscount:f3}");
        }   
    }
}
