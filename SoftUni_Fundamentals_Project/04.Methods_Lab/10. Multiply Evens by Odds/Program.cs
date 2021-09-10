using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));

            Console.WriteLine(GetMultipleOfEvenAndOdds(number));
        }

        private static int GetSumOddDigits(int number)
        {
            int currDigits = 0;
            int sum = 0;

            while (number > 0)
            {
                currDigits = number % 10;

                if (currDigits % 2 != 0)
                {
                    sum += currDigits;
                }

                number /= 10;

            }

            return sum;
        }

        private static int GetsumOfEvenDigits(int number)
        {
            int currDigits = 0;
            int sum = 0;

            while (number > 0)
            {
                currDigits = number % 10;

                if (currDigits % 2 == 0)
                {
                    sum += currDigits;
                }

                number /= 10;
            }

            return sum;
        }
        private static int GetMultipleOfEvenAndOdds(int number)
        {
            return GetsumOfEvenDigits(number) * GetSumOddDigits(number);
        }
    }
}
