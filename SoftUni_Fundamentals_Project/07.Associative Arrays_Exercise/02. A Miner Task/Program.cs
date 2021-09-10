using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> quantityByResourse = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (quantityByResourse.ContainsKey(line))
                {
                    quantityByResourse[line] += quantity;
                }

                else
                {
                    quantityByResourse.Add(line, quantity);
                }
            }

            foreach (var kvp in quantityByResourse)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
