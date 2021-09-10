using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> comoanies = new SortedDictionary<string, List<string>>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] parts = line.Split(" -> ");

                string company = parts[0];
                string employeeId = parts[1];

                if (!comoanies.ContainsKey(company))
                {
                    comoanies.Add(company, new List<string>());
                }

                comoanies[company].Add(employeeId);
            }

            foreach (var company in comoanies)
            {
                Console.WriteLine(company.Key);

                List<string> uniqueEmployees = company.Value.Distinct()
                    .Distinct()
                    .ToList();

                foreach (var employee in uniqueEmployees)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
