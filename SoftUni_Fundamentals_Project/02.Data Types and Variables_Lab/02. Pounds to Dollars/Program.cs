using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal num = decimal.Parse(Console.ReadLine());
            decimal result = num * 1.31M;

            Console.WriteLine($"{result:f3}");
        }
    }
}
