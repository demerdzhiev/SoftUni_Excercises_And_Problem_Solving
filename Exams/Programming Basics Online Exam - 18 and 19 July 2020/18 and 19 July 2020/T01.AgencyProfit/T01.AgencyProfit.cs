using System;

namespace T01.AgencyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int childrenTicket = int.Parse(Console.ReadLine());
            double priceAdultTicket = double.Parse(Console.ReadLine());
            double servicesTax = double.Parse(Console.ReadLine());

            double priceChildrenTicket = priceAdultTicket * 0.3;

            double totalPriceAdultTicket = priceAdultTicket + servicesTax;
            double totalPriceChildrenicket = priceChildrenTicket + servicesTax;
            double totalProfit = (adultTickets * totalPriceAdultTicket + childrenTicket * totalPriceChildrenicket)*0.2;

            Console.WriteLine($"The profit of your agency from {companyName} tickets is {totalProfit:f2} lv.");
        }
    }
}
