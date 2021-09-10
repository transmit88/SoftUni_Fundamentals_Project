using System;

namespace _04._Back_In_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double minplus30 = minutes + 30;

            if (minplus30 > 59)
            {
                minplus30 = (minplus30 - 60);
                hour += 1;
            }

            if (hour == 24)
            {
                hour = 0;
            }

            if (minplus30 < 10)
            {
                Console.WriteLine($"{hour}:0{minplus30}");
            }

            else
            {
                Console.WriteLine($"{hour}:{minplus30}");
            }
        }
    }
}
