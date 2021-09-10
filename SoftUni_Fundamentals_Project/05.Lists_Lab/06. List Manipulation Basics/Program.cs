using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
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
            int counter = 0;

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    
                    break;
                }

                string[] tokens = line.Split();
                
                switch(tokens[0])
                {
                    
                    case "Add":
                        int numerToAdd = int.Parse(tokens[1]);
                        numbers.Add(numerToAdd);
                        break;
                    case "Remove":;
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int indexToRemove = int.Parse(tokens[1]);
                        numbers.RemoveAt(indexToRemove);
                        break;
                    case "Insert":
                        int numerToInsert = int.Parse(tokens[1]);
                        int indexToInsert = int.Parse(tokens[2]);
                        numbers.Insert(indexToInsert, numerToInsert);
                        break;
                    case "Contains":
                        counter++;
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
                        counter++;
                        List<int> evenList = numbers
                            .Where(n => n % 2 == 0)
                            .ToList();
                        Console.WriteLine(string.Join(" ", evenList));
                        break;
                    case "PrintOdd":
                        counter++;
                        List<int> oddList = numbers
                            .Where(n => n % 2 == 1)
                            .ToList();
                        Console.WriteLine(string.Join(" ", oddList));
                        break;
                    case "GetSum":
                        counter++;
                        int getSum = numbers.Sum();
                        Console.WriteLine(getSum);
                        break;
                    case "Filter":
                        counter++;
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

            if (counter == 0 && copyListNumber != numbers)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}
