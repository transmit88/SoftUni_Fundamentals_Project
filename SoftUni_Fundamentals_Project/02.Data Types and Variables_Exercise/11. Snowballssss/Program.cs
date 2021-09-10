using System;

namespace _11._Snowballssss
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int snowballSnowHighest = 0;
            int snowballTimeHighest = 0;
            int snowballQualityHighest = 0;
            double snowballValue = 0;
            double highestSnowball = 0;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = Math.Pow((snowballSnow / snowballTime), snowballQuality);

                if (snowballValue > highestSnowball)
                {
                    highestSnowball = snowballValue;
                    snowballSnowHighest = snowballSnow;
                    snowballTimeHighest = snowballTime;
                    snowballQualityHighest = snowballQuality;
                }
            }

            Console.WriteLine($"{snowballSnowHighest} : {snowballTimeHighest} = {highestSnowball} ({snowballQualityHighest})");
        }
    }
}
