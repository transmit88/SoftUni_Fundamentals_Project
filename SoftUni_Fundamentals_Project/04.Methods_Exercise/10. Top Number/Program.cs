using System;

namespace _10._Top_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (IsTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool IsTopNumber(int number)
        {
            return IsDivisibleBy(number, 8) && ContainsOddDigit(number);
        }

        private static bool IsDivisibleBy(int number, int divide)
        {
            int sum = 0;

            while (number != 0)
            {
                int lastDigit = number % 10;
                sum += lastDigit;
                number /= 10;
            }

            return sum % divide == 0;
        }

        private static bool ContainsOddDigit(int number)
        {
            while (number != 0)
            {
                int lastDigit = number % 10;

                if (lastDigit % 2 != 0)
                {
                    return true;
                }

                number /= 10;
            }

            return false;
        }
    }
}
