using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                string line = Console.ReadLine();

                if (line == "END")
                {
                    break;
                }

                Console.WriteLine(IsPalindrome(line));
            }
        }

        private static bool IsPalindrome(string text)
        {
            for (int i = 0; i < text.Length / 2; i++)
            {
                if (text[i] != text[text.Length - 1 - i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
