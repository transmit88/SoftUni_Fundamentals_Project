using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            string biggestCegModel = string.Empty;
            double biggestVolum = 0;

            for (int i = 0; i < numberOfKegs; i++)
            {
                string model = Console.ReadLine();
                double radious = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double singleKegVolume = Math.PI * radious * radious * height;

                if (singleKegVolume > biggestVolum)
                {
                    biggestVolum = singleKegVolume;
                    biggestCegModel = model;
                }
            }

            Console.WriteLine(biggestCegModel);
        }
    }
}
