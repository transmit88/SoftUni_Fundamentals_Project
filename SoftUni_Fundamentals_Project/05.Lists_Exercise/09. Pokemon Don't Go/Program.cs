using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int sum = 0;

            while (numbers.Count > 0)
            {

                int idx = int.Parse(Console.ReadLine());

                if (idx < 0)
                {
                    int removeNumber1 = numbers[0];
                        sum += removeNumber1;
                    numbers[0] = numbers[numbers.Count - 1];

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= removeNumber1)
                        {
                            numbers[i] += removeNumber1;
                        }
                        else
                        {
                            numbers[i] -= removeNumber1;
                        }
                    }
                }

                else if (idx >= numbers.Count)
                {
                    int removeNumber2 = numbers[numbers.Count - 1];
                    sum += removeNumber2;
                    numbers[numbers.Count - 1] = numbers[0];

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i] <= removeNumber2)
                        {
                            numbers[i] += removeNumber2;
                        }
                        else
                        {
                            numbers[i] -= removeNumber2;
                        }
                    }
                }
                else
                {
                    int removeNumber3 = numbers[idx];
                    sum += removeNumber3;
                    numbers.RemoveAt(idx);

                    for (int i = 0; i < numbers.Count; i++)
                    {

                        if (numbers[i] <= removeNumber3)
                        {
                            numbers[i] += removeNumber3;
                        }
                        else
                        {
                            numbers[i] -= removeNumber3;
                        }
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
