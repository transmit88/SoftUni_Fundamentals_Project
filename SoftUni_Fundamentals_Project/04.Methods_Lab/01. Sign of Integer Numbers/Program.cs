﻿using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintSing(n);
        }

        private static void PrintSing(int num)
        {
            if (num > 0)
            {
                Console.WriteLine($"The number {num} is positive.");
            }

            else if (num < 0)
            {
                Console.WriteLine($"The number {num} is negative.");
            }

            else
            {
                Console.WriteLine($"The number {num} is zero.");
            }
        }
    }
}
