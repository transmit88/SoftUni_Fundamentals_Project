using System;
using System.Linq;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] array = Console.ReadLine()
                .Split(' ')
                .Select(double.Parse)
                .ToArray();

            foreach (var number in array)
            {
                int roundedNum = (int)Math.Round(number, MidpointRounding.AwayFromZero);

                Console.WriteLine($"{number} => {roundedNum}");
            }


            //string numbers = Console.ReadLine();
            //string[] items = numbers.Split();
            //double[] num = new double[items.Length];

            //for (int i = 0; i <=  items.Length-1; i++)
            //{
            //    num[i] = double.Parse(items[i]);
            //}

            //int[] roundedNum = new int[num.Length];

            //for (int i = 0; i <= num.Length-1; i++)
            //{
            //    roundedNum[i] = (int)Math.Round(num[i], MidpointRounding.AwayFromZero);

            //    Console.WriteLine($"{num[i]} => {roundedNum[i]}");
            //}

        }
    }
}
