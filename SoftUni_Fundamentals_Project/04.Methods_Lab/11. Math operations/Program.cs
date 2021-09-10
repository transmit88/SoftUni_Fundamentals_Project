using System;

namespace _11._Math_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            char simbol = char.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            double total = Calculate(a, simbol, b);

            Console.WriteLine(total);
        }

        private static double Calculate(int a, char simbol, int b)
        {
            double result = 0;

            switch (simbol)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
                default:
                    break;
            }

            return result;
        }
    }
}
