using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());

            while (true)
            {
                string passeenger = Console.ReadLine();

                if (passeenger == "end")
                {
                    break;
                }

                string[] addPaseenger = passeenger.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (addPaseenger.Length == 2)
                {
                    int passengers = int.Parse(addPaseenger[1]);

                    wagons.Add(passengers);
                }

                else
                {
                    int passengers = int.Parse(addPaseenger[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currentWagon = wagons[i];

                        if (currentWagon + passengers <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
