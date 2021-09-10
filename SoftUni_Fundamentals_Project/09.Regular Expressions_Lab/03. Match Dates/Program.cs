using System;
using System.Text.RegularExpressions;

namespace _03._Match_Dates
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b(\d{2})([-./])([A-Z][a-z]{2})\2(\d{4})\b";

            string dates = Console.ReadLine();

            MatchCollection dateCollection = Regex.Matches(dates, pattern);

            foreach (Match date in dateCollection)
            {
                Console.WriteLine($"Day: {date.Groups[1]}, Month: {date.Groups[3]}, Year: {date.Groups[4]}");
            }

        }
    }
}
