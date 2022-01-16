using System;

namespace ExT03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string day = Console.ReadLine();
            double totalprice = 0;
            double totalprice2 = 0;
            if (type == "Students")
            {
                switch (day)
                {
                    case "Friday":
                        totalprice = group * 8.45;
                        if (group >= 30)
                        {
                            totalprice2 = totalprice - totalprice * 0.15;
                            Console.WriteLine($"Total price: {totalprice2:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"Total price: {totalprice:F2}");
                        }
                        break;
                    case "Saturday":
                        totalprice = group * 9.80;
                        if (group >= 30)
                        {
                            totalprice2 = totalprice - totalprice * 0.15;
                            Console.WriteLine($"Total price: {totalprice2:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"Total price: {totalprice:F2}");
                        }
                        break;
                    case "Sunday":
                        totalprice = group * 10.46;
                        if (group >= 30)
                        {
                            totalprice2 = totalprice - totalprice * 0.15;
                            Console.WriteLine($"Total price: {totalprice2:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"Total price: {totalprice:F2}");
                        }
                        break;
                }
            }
            if (type == "Business")
            {
                switch (day)
                {
                    case "Friday":
                        totalprice = group * 10.90;
                        if (group >= 100)
                        {
                            totalprice2 = (group - 10) * 10.90;
                            Console.WriteLine($"Total price: {totalprice2:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"Total price: {totalprice:F2}");
                        }
                        break;
                    case "Saturday":
                        totalprice = group * 15.60;
                        if (group >= 100)
                        {
                            totalprice2 = (group - 10) * 15.60;
                            Console.WriteLine($"Total price: {totalprice2:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"Total price: {totalprice:F2}");
                        }
                        break;
                    case "Sunday":
                        totalprice = group * 16;
                        if (group >= 100)
                        {
                            totalprice2 = (group - 10) * 16; Console.WriteLine($"Total price: {totalprice2:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"Total price: {totalprice:F2}");
                        }
                        break;
                }
            }
            if (type == "Regular")
            {
                switch (day)
                {
                    case "Friday":
                        totalprice = group * 15;
                        if (group >= 10 && group <= 20)
                        {
                            totalprice2 = totalprice - totalprice * 0.05;
                            Console.WriteLine($"Total price: {totalprice2:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"Total price: {totalprice:F2}");
                        }
                        break;
                    case "Saturday":
                        totalprice = group * 20;
                        if (group >= 10 && group <= 20)
                        {
                            totalprice2 = totalprice - totalprice * 0.05;
                            Console.WriteLine($"Total price: {totalprice2:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"Total price: {totalprice:F2}");
                        }
                        break;
                    case "Sunday":
                        totalprice = group * 22.50;
                        if (group >= 10 && group <= 20)
                        {
                            totalprice2 = totalprice - totalprice * 0.05;
                            Console.WriteLine($"Total price: {totalprice2:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"Total price: {totalprice:F2}");
                        }
                        break;
                }
            }
        }
    }
}
