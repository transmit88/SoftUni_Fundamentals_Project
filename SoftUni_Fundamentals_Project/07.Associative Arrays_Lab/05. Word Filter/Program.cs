using System;
using System.Linq;

namespace _05._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where(x => x.Length % 2 == 0)
                .ToList()
                .ForEach(x => Console.WriteLine(x));

            //Console.WriteLine("LINQ PERFORMANCE");
        }
    }
}
