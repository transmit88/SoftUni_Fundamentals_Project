using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> priceByProduct = new Dictionary<string, decimal>();
            Dictionary<string, int> quantityByProduct = new Dictionary<string, int>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "buy")
                {
                    break;
                }

                string[] pards = line.Split();

                string product = pards[0];
                decimal price = decimal.Parse(pards[1]);
                int quantity = int.Parse(pards[2]);

                if (priceByProduct.ContainsKey(product))
                {
                    quantityByProduct[product] += quantity;
                    priceByProduct[product] = price;
                }

                else
                {
                    priceByProduct.Add(product, price);
                    quantityByProduct.Add(product, quantity);
                }

            }

            decimal totalSum = 0.0m;

            foreach (var kvp in priceByProduct)
            {
                string product = kvp.Key;
                decimal price = kvp.Value;
                int quantity = quantityByProduct[product];

                decimal totalPrice = quantity * price;

                Console.WriteLine($"{product} -> {totalPrice:F2}");
            }

            // var sorted = priceByProduct
            //      .OrderByDescending(kvp => kvp.Value * quanTityByProduct[kvp.Key])
            //      .ToDictionary(x => x.Key, x => x.Value * quanTityByProduct[x.Key])
        }
    }
}
