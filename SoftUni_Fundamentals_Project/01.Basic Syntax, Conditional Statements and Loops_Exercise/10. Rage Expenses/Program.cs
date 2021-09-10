using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double diplayPrice = double.Parse(Console.ReadLine());

            double price = 0;

            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 12 == 0)
                {
                    price += diplayPrice;
                }

                if (i % 6 == 0)
                {
                    price += keyboardPrice;
                }

                if (i % 3 == 0)
                {
                    price += mousePrice;
                }

                if (i % 2 == 0)
                {
                    price += headsetPrice;
                }

            }

            Console.WriteLine($"Rage expenses: {price:F2} lv.");
        }
    }
}
