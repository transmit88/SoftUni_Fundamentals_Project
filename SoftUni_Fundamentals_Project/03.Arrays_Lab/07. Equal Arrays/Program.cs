﻿using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] arr2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] != arr2[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    break;
                }

                else
                {
                    int sum = arr1.Sum();

                    if (i + 2 > arr1.Length)
                    {
                        Console.WriteLine($"Arrays are identical. Sum: {sum}");
                    }
                }
            } 
        }
    }
}
