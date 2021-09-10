using System;
using System.Linq;
using System.Text;

namespace _05._Multiply_Big_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            Console.WriteLine(MultiplyBigNumbers(number, multiplier));

        }

        private static string MultiplyBigNumbers(string number, int multiplier)
        {
            if (multiplier == 0)
            {
                return "0";
            }
           
            int remainder = 0;

            StringBuilder sb = new StringBuilder();
            
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = number[i] - '0'; // digit = int.Parse(number[i].ToString());

                remainder += multiplier * digit;
                int remainderLastDigit = 0;


                if (remainder > 9)
                {
                    remainderLastDigit = remainder % 10;
                    remainder /= 10;

                    sb.Append(remainderLastDigit.ToString());
                }

                else
                {
                    sb.Append(remainder.ToString());
                    remainder = 0;
                }
            }

            if (remainder > 0)
            {
                sb.Append(remainder.ToString());
            }

            return string.Concat(sb.ToString().Reverse());
        }
    }
}
