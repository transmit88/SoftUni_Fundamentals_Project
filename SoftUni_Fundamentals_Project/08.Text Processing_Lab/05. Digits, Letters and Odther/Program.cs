using System;
using System.Linq;
using System.Text;

namespace Text_Processing___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            StringBuilder nums = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder other = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                var chartext = str[i];

                if (char.IsDigit(chartext))
                {
                    nums.Append(chartext);
                }

                else if (char.IsLetter(chartext))
                {
                    letters.Append(chartext);
                }

                else
                {
                    other.Append(chartext);
                }
            }

            Console.WriteLine($"{nums}\n{letters}\n{other}");
        }
    }
}
