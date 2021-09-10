﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int[] bombData = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int bombNumber = bombData[0];
            int bombPower = bombData[1];

            while (true)
            {
                int idx = numbers.IndexOf(bombNumber);

                if (idx == -1)
                {
                    break;
                }

                int startIdx = idx - bombPower;

                if (startIdx < 0)
                {
                    startIdx = 0;
                }

                int count = 2 * bombPower + 1;

                if (count > numbers.Count - startIdx)
                {
                    count = numbers.Count - startIdx;
                }

                numbers.RemoveRange(startIdx, count);
            }

            int sum = 0;

            foreach (var number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);
        }
    }
}
