using System;
using System.Linq;

namespace _04._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(x => x)
                .ToArray();

            int count = number.Length >= 3 ? 3 : number.Length;

            for (int i = 0; i < count; i++)
            {
                Console.Write($"{number[i]} ");
            }
        }
    }
}
