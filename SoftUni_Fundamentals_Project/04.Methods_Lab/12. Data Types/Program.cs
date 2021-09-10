using System;

namespace _12._Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "int")
            {
                int number = int.Parse(Console.ReadLine());
                GetIntSum(number);
            }

            else if (input == "real")
            {
                double num = double.Parse(Console.ReadLine());
                GetDiubleSum(num);
            }

            else if (input == "string")
            {
                string str = Console.ReadLine();
                Console.WriteLine($"${str}$");
            }

        }

        private static void GetDiubleSum(double num)
        {
            num *= 1.5;
            Console.WriteLine($"{num:F2}");
        }

        private static void GetIntSum(int number)
        {
            number *= 2;
            Console.WriteLine(number);
        }
    }
}
