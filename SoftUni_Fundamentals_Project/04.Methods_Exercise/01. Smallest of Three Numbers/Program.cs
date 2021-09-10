using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int sum = GetSum(firstNumber, secondNumber, thirdNumber);

            Console.WriteLine(sum);
        }

        private static int GetSum(int firstNumber, int secondNumber, int thirdNumber)
        {
            int smalSum = Math.Min(Math.Min(firstNumber, secondNumber), thirdNumber);

            //if(firstNumber < smalSum)
            //{
            //    smalSum = firstNumber;
            //}

            //if (secondNumber < smalSum)
            //{
            //    smalSum = secondNumber;
            //}

            //if (thirdNumber < smalSum && thirdNumber < firstNumber)
            //{
            //    smalSum = thirdNumber;
            //}

            return smalSum;
        }
    }
}
