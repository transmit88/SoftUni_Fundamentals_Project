﻿using System;
using System.Linq;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstElements = Console.ReadLine()
                .Split()
                .ToArray();
            string[] secondElements = Console.ReadLine()
                .Split()
                .ToArray();

            for (int i = 0; i < secondElements.Length; i++)
            {
                for (int j = 0; j < firstElements.Length; j++)
                {
                    if(secondElements[i] == firstElements[j])
                    {
                        Console.Write($"{secondElements[i]} ");
                    }
                }
            }

        }
    }
}
