using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    public class Demon
    {
        public string Name { get; set; }

        public int Healt { get; set; }

        public double Damage { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] inputDemons = Console.ReadLine()
                .Split(new[]{',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Regex hpRegex = new Regex(@"[^\d+-.*\/]");
            Regex numberRegex = new Regex(@"[+\-]{0,1}\d\.?\d*");
            Regex amplifiersRegex = new Regex(@"[*\/]");

            List<Demon> demons = new List<Demon>();

            foreach (var demon in inputDemons)
            {
                int healt = hpRegex.Matches(demon)
                    .Select(m => char.Parse(m.Value))
                    .Sum(x => x);

                MatchCollection numberMatches = numberRegex.Matches(demon);

                double damage = GetBaseDamage(numberMatches);

                MatchCollection amplifiersMatches = amplifiersRegex.Matches(demon);

                foreach (Match match in amplifiersMatches)
                {
                    if (match.Value == "*")
                    {
                        damage *= 2;
                    }

                    else
                    {
                        damage /= 2;
                    }
                }

                demons.Add(new Demon
                {
                    Name = demon,
                    Damage = damage,
                    Healt = healt
                });
            }

            List<Demon> sorted = demons
                .OrderBy(d => d.Name)
                .ToList();

            foreach (Demon demon in sorted)
            {
                Console.WriteLine($"{demon.Name} - {demon.Healt} health, {demon.Damage:F2} damage");
            }
        }

        private static double GetBaseDamage(MatchCollection matchCollection)
        {
            double damage = 0;

            foreach (Match match in matchCollection)
            {
                damage += double.Parse(match.Value);
            }

            return damage;
        }
    }
}
