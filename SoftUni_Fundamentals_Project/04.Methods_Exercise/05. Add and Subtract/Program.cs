using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            int sum = Sum(first, second);

            int diff = Substract(sum, third);

            Console.WriteLine(diff);
        }

        private static int Substract(int first, int second)
        {
            return first - second;
        }

        private static int Sum(int first, int second)
        {
            return first + second;
        }
    }
}
