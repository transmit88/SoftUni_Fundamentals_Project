using System;
using System.Linq;

namespace _14._Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] number = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int leftNumber = number.Length / 4 - 1;
            int rightNumber = 3 * number.Length / 4;
        }
    }
}
