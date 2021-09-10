using System;

namespace _07._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNmae = Console.ReadLine();
            string secondNmae = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine($"{firstNmae}{delimiter}{secondNmae}");
        }
    }
}
