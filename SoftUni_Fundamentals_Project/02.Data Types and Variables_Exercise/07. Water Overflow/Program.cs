using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int volumOfTank = 255;
            int capacity = 0;

            for (int i = 1; i <= numberOfLines; i++)
            {
                int liters = int.Parse(Console.ReadLine());

               if ((capacity + liters) <= volumOfTank)
                {
                    capacity += liters;
                }

               else
                {
                    Console.WriteLine("Insufficient capacity!");
                }

            }

            Console.WriteLine(capacity);
        }
    }
}
