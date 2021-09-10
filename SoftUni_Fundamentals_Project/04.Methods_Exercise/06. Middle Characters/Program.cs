using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string middle = Getmiddle(str);

            Console.WriteLine(middle);
        }

        private static string Getmiddle(string str)
        {
            //even
            if (str.Length % 2 == 0)
            {
                return $"{str[str.Length / 2 - 1]}{str[str.Length / 2]}";
            }
            
            //odd
            return $"{str[(str.Length - 1) / 2]}";
        }
    }
}
