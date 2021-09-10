using System;

namespace _0._1_Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] days = { "Invalid day!", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (n >= 1 && n <= 7)
            {
                Console.WriteLine(days[n]);
            }

            else
            {
                Console.WriteLine(days[0]);
            }
        }
    }
}
