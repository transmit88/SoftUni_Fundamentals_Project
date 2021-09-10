using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char tird = char.Parse(Console.ReadLine());

            Console.WriteLine($"{first}{second}{tird}");
            Console.WriteLine(Char.ToString(first) + Char.ToString(second) + Char.ToString(tird));
        }
    }
}
