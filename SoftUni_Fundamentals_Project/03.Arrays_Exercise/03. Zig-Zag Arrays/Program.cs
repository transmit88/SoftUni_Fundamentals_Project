using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] fromLeft = new int[n];
            int[] fromRight = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentArr = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2 == 0)
                {
                    fromLeft[i] = currentArr[0];
                    fromRight[i] = currentArr[1];
                }

                else
                {
                    fromLeft[i] = currentArr[1];
                    fromRight[i] = currentArr[0];
                }

            }

            Console.WriteLine(string.Join(" ",fromLeft));
            Console.WriteLine(string.Join(" ",fromRight));
        }
    }
}
