using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int originNumber = int.Parse(Console.ReadLine());
            int number = originNumber;
            int sum = 0;

            while (number > 0)
            {
                int lastDigit = number % 10;
                number /= 10;
                int curentFactorial = 1;

                for (int i = 2; i <= lastDigit; i++)
                {
                    curentFactorial *= i;
                }

                sum += curentFactorial;
            }

            bool isStrong = sum == originNumber;

            if(isStrong == true)
            {
                Console.WriteLine("yes");
            }

            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
