using System;
using System.Linq;

namespace _06._Even_and_Odd_Subtraction
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] number = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int evenNumber = 0;
            int oddNumber = 0;

            foreach (var num in number)
            {

                if (num % 2 == 0)
                {
                    evenNumber += num;
                }

                else
                {
                    oddNumber += num;
                }

            }

            int result = evenNumber - oddNumber;

            Console.WriteLine(result);
        }
    }
}
