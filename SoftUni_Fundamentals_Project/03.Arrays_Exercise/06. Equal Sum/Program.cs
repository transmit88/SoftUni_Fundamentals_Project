using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            if (numArr.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            int left = 0;
            int right = 0;
            bool found = false;

            for (int i = 0; i < numArr.Length; i++)
            {
                for (int L = 0; L < i; L++)
                {
                    left += numArr[L];
                }

                for (int R = i + 1; R < numArr.Length; R++)
                {
                    right += numArr[R];
                }

                if (left == right)
                {
                    Console.WriteLine(i);
                    found = true;
                }

                else
                {
                    left = 0;
                    right = 0;
                }
            }

            if (found == false)
            {
                Console.WriteLine("no");
            }
        }
    }
}
