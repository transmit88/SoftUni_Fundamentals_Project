using System;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            string allElements = "";

            for (int i = 0; i < n; i++)
            {
                int peopleInVagon = int.Parse(Console.ReadLine());
                allElements += peopleInVagon + " ";
                sum += peopleInVagon;
            }

            Console.WriteLine(allElements.Trim());
            Console.WriteLine(sum);
        }
    }
}
