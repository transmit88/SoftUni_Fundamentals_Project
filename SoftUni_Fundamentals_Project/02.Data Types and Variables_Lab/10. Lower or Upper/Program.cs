using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());

            if (firstChar == char.ToLower(firstChar))
            {
                Console.WriteLine("lower-case");
            }

            else if (firstChar == char.ToUpper(firstChar))
            {
                Console.WriteLine("upper-case");
            }
        }
    }
}
