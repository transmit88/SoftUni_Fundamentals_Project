using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> raser = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToDictionary(x => x, x => 0);

            Regex nameRegex = new Regex(@"[A-Za-z]+");

            Regex digitRegex = new Regex(@"\d");

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end of race")
                {
                    break;
                }

                MatchCollection letterMatches = nameRegex.Matches(line);
                MatchCollection digitMatches = digitRegex.Matches(line);

                string name = GetName(letterMatches);
                int sum = GetSum(digitMatches);

                if (!raser.ContainsKey(name))
                {
                    continue;
                }

                raser[name] += sum;
            }

            string[] winners = raser
                .OrderByDescending(x => x.Value)
                .Take(3)
                .Select(x => x.Key)
                .ToArray();

            Console.WriteLine($"1st place: {winners[0]}");
            Console.WriteLine($"2nd place: {winners[1]}");
            Console.WriteLine($"3rd place: {winners[2]}");

        }

        private static int GetSum(MatchCollection digitMatches)
        {
            int sum = 0;
            foreach (Match match in digitMatches)
            {
                sum += int.Parse(match.Value);
            }
            return sum;
        }

        private static string GetName(MatchCollection matches)
        {
            StringBuilder sb = new StringBuilder();

            foreach (Match match in matches)
            {
                sb.Append(match.Value);
            }

            return sb.ToString();
        }
    }
}
