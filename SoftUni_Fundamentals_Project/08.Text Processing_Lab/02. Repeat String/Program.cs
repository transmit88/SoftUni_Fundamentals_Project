using System;

namespace _02._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string result = string.Empty;

            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    result += item;
                }
            }

            Console.WriteLine(result);
        }
    }
}
