using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            string result = RepeatString(str, count);

            Console.WriteLine(result);
        }

        static string RepeatString(string str, int count)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                result.Append(str);
            }
            return result.ToString();
        }
    }
}
