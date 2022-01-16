using System;
using System.Text.RegularExpressions;

namespace T02.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"^@#+(?<barcode>[A-Z][A-Za-z0-9]{4,}[A-Z])@#+$");
            var digitRegex = new Regex(@"\d");

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var match = regex.Match(input);
                if (match.Success)
                {
                    string name = match.Groups["barcode"].Value;
                    var digitMatch = digitRegex.Matches(name);
                    string productGroup = string.Empty;

                    foreach (Match digit in digitMatch)
                    {
                        if (digit.Success)
                        {
                            productGroup += digit.Value;
                        }
                    }
                    if (productGroup.Length == 0)
                    {
                        productGroup = "00";
                    }

                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}
