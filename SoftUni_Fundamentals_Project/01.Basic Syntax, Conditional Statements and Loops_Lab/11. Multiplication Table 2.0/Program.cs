using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var num1 = int.Parse(Console.ReadLine());
            var num2 = int.Parse(Console.ReadLine());
            var sum = 0;
            
            do
            {
                sum = num1 * num2;
                Console.WriteLine($"{num1} X {num2} = {sum}");
                num2++;
            } while (num2 <= 10);
        }
    }
}
