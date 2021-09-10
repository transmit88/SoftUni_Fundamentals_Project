using System;

namespace _10._Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var sum = 0;

            for (int i = 1; i <= 10; i++)
            {
                sum = num * i;

                Console.WriteLine($"{num} X {i} = {sum}");
            }
        }
    }
}
