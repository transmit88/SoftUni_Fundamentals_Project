using System;
using System.Text.RegularExpressions;

namespace _02._Match_Phone_Number
{
    class Program
    {
        static void Main(string[] args)
        {

            string numbers = Console.ReadLine();
            string pattern = @"\+[3][5][9]( |-)[2](\1)\d{3}(\1)\d{4}\b";

            Regex regex = new Regex(pattern);

            MatchCollection matchedNumbers = regex.Matches(numbers);

            Console.WriteLine(string.Join(", ", matchedNumbers));

        }
    }
}
