using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());

            PrintTriangle(end);
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }

        static void PrintTriangle(int end)
        {
            for (int i = 1; i <= end; i++)
            {
                PrintLine(1, i);
            }

            for (int i = end - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
