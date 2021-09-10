using System;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string userName in userNames)
            {
                if (IsValid(userName))
                {
                    Console.WriteLine(userName);
                }
            }
        }

        private static bool IsValid(string userName)
        {
            return IsValidLength(userName) && ContainsValidSymbols(userName);
        }

        private static bool ContainsValidSymbols(string userName)
        {
            foreach (char symbol in userName)
            {

                if (!char.IsLetterOrDigit(symbol) &&
                    symbol != '_' &&
                    symbol != '-')
                {
                    return false;
                }

            }
            return true;
        }

        private static bool IsValidLength(string userName)
        {
            return userName.Length >= 3 && userName.Length <= 16;
        }
    }
}
