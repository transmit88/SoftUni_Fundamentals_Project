using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Star_Enigma
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();
            int n = int.Parse(Console.ReadLine());
            Regex keyRegex = new Regex(@"[STARstar]");
            Regex regex = new Regex(@"^[^@\-!:<]*@(?<planet>[A-Za-z]+)[^@\-!:<]*\:(?<population>\d+)[^@\-!:<]*!(?<action>[AD])![^@\-!:<]*->(?<soldiers>\d+)[^@\-!:<]*$");
            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                int key = keyRegex.Matches(text).Count;
                string decryped = Decryped(text, key);

                Match match = regex.Match(decryped);

                if (!match.Success)
                {
                    continue;
                }

                string planetname = match.Groups["planet"].Value;

                string action = match.Groups["action"].Value;

                if (action == "A")
                {
                    attackedPlanets.Add(planetname);
                }
                else
                {
                    destroyedPlanets.Add(planetname);
                }
            }
            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");

            Printplanets(attackedPlanets);


            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");

            Printplanets(destroyedPlanets);
        }

        private static void Printplanets(List<string> Planets)
        {
            List<string> sortred = Planets
                .OrderBy(x => x)
                .ToList();

            foreach (var item in sortred)
            {
                Console.WriteLine($"-> {item}");
            }
        }

        private static string Decryped(string text, int key)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var item in text)
            {
                sb.Append((char)(item - key));
            }

            return sb.ToString();
        }
    }
}