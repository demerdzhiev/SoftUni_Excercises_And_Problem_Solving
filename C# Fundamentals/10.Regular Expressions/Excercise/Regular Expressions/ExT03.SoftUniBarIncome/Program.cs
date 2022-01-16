using System;
using System.Text.RegularExpressions;

namespace ExT03.SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-Z][a-z]+)%[^|$%.]*<(?<product>[\w]+)>[^|$%.]*\|(?<quantity>[\d+]+)\|[^|$%.]*(?<price>[\d]+[.]?[\d]+)\$";
            string input = Console.ReadLine();
            double totalIncome = 0;
            while (input != "end of shift")
            {
                Regex regex = new Regex(pattern);
                bool isValid = regex.IsMatch(input);
                if (isValid)
                {
                    string customer = regex.Match(input).Groups["customer"].Value;
                    string product = regex.Match(input).Groups["product"].Value;
                    int quantity = int.Parse(regex.Match(input).Groups["quantity"].Value);
                    double price = double.Parse(regex.Match(input).Groups["price"].Value);

                    double totalPrice = price * quantity;
                    totalIncome = totalPrice;
                    Console.WriteLine($"{customer}: {product} - {totalPrice:f2}");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
