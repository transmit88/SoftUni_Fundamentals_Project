using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<int> copyListNumber = new List<int>(numbers);

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();

                switch (tokens[0])
                {
                    case "Contains":
                        int numberContains = int.Parse(tokens[1]);

                        if (numbers.Contains(numberContains))
                        {
                            Console.WriteLine("Yes");
                        }

                        else
                        {
                            Console.WriteLine("No such number");
                        }

                        break;
                    case "PrintEven":
                        List<int> evenList = numbers
                            .Where(n => n % 2 == 0)
                            .ToList();

                        Console.WriteLine(string.Join(" ", evenList));
                        break;
                    case "PrintOdd":
                        List<int> oddList = numbers
                            .Where(n => n % 2 == 1)
                            .ToList();

                        Console.WriteLine(string.Join(" ", oddList));
                        break;
                    case "GetSum":
                        int getSum = numbers.Sum();

                        Console.WriteLine(getSum);
                        break;
                    case "Filter":
                        int currentValue = int.Parse(tokens[2]);

                        if (tokens[1] == ">=")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n >= currentValue)));
                        }

                        else if (tokens[1] == ">")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n > currentValue)));
                        }

                        else if (tokens[1] == "<=")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n <= currentValue)));
                        }

                        else if (tokens[1] == "<")
                        {
                            Console.WriteLine(string.Join(" ", numbers.Where(n => n < currentValue)));
                        }
                        break; ;
                    default:
                        break;
                }
            }
        }
    }
}