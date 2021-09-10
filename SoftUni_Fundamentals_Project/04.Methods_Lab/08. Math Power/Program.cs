using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double total = RiseToPower(number, power);

            Console.WriteLine(total);
        }

        static double RiseToPower(double number, int power)
        {
            double result = 0;
            result = Math.Pow(number, (power * 1.0));

            return result;
        }
    }
}
