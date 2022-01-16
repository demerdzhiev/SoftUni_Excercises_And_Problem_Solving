using System;
using System.Collections.Generic;
using System.Linq;

namespace ExT08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                string[] inputArray = inputLine.Split(" -> ");
                string companyName = inputArray[0];
                string employeeID = inputArray[1];

                if (!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                }

                if (!companies[companyName].Contains(employeeID))
                {
                    companies[companyName].Add(employeeID);
                }

                inputLine = Console.ReadLine();
            }


            foreach (var kvp in companies.OrderBy(kvp => kvp.Key))
            {
                Console.WriteLine($"{kvp.Key}");

                foreach (var employeeID in kvp.Value)
                {
                    Console.WriteLine($"-- {employeeID}");
                }
            }
        }
    }
}
