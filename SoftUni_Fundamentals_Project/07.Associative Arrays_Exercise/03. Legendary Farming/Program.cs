using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> legendaryItems = new Dictionary<string, int>
            {
                {"shards", 0},
                {"fragments", 0},
                {"motes", 0},
            };

            SortedDictionary<string, int> junkItems = new SortedDictionary<string, int>();

            bool isRunning = true;
            string winerItem = string.Empty;

            while (isRunning)
            {
                string[] pards = Console.ReadLine().Split();

                for (int i = 0; i < pards.Length; i += 2)
                {
                    int quantity = int.Parse(pards[i]);
                    string item = pards[i + 1].ToLower();

                    if (legendaryItems.ContainsKey(item))
                    {
                        legendaryItems[item] += quantity;

                        if (legendaryItems[item] >= 250)
                        {
                            winerItem = item;
                            legendaryItems[item] -= 250;
                            isRunning = false;
                            break;
                        }
                    }

                    else
                    {
                        if (junkItems.ContainsKey(item))
                        {
                            junkItems[item] += quantity;
                        }

                        else
                        {
                            junkItems.Add(item, quantity);
                        }
                    }
                }
            }

            
            if (winerItem == "shards")
            {
                Console.WriteLine("Shadowmourne obtained!");
            }

            else if (winerItem == "fragments")
            {
                Console.WriteLine("Valanyr obtained!");
            }

            else
            {
                Console.WriteLine("Dragonwrath obtained!");
            }

            Dictionary<string, int> sortedLegendaryItems = legendaryItems
                .OrderByDescending(i => i.Value)
                .ThenBy(i => i.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in sortedLegendaryItems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            //sortirame junkItems  SortedDictionary.

            //Dictionary<string, int> sortedJunkItems = junkItems
            //   .OrderBy(if => i.key)  
            //   .ToDictionary(x => x.Key, x => x.Value)

            foreach (var kvp in junkItems)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
