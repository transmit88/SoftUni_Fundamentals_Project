using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._ForceBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> memberBySide = new Dictionary<string, List<string>>();

            Dictionary<string, string> member = new Dictionary<string, string>();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Lumpawaroo")
                {
                    break;
                }

                if (line.Contains(" | "))
                {
                    string[] parts = line.Split(" | ");

                    string forceSide = parts[0];
                    string forceUser = parts[1];

                    if (member.ContainsKey(forceUser))
                    {
                        continue;
                    }

                    if (!memberBySide.ContainsKey(forceSide))
                    {
                        memberBySide.Add(forceSide, new List<string>());
                    }

                    memberBySide[forceSide].Add(forceUser);
                    member.Add(forceUser, forceSide);
                }
                else
                {
                    string[] parts = line.Split(" -> ");

                    string forseUser = parts[0];
                    string forseSide = parts[1];

                    if (!memberBySide.ContainsKey(forseSide))
                    {
                        memberBySide.Add(forseSide, new List<string>());
                    }

                    if (member.ContainsKey(forseUser))
                    {
                        string oldSide = member[forseUser];

                        memberBySide[oldSide].Remove(forseUser);
                        memberBySide[forseSide].Add(forseUser);
                        member[forseUser] = forseSide;
                    }

                    else
                    {
                        memberBySide[forseSide].Add(forseUser);
                        member.Add(forseUser, forseSide);
                    }

                    Console.WriteLine($"{forseUser} joins the {forseSide} side!");
                }
            }

            Dictionary<string, List<string>> result = memberBySide
                .Where(s => s.Value.Count > 0)
                .OrderByDescending(s => s.Value.Count)
                .ThenBy(s => s.Key)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var kvp in result)
            {
                Console.WriteLine($"Side: {kvp.Key}, Members: {kvp.Value.Count}");

                kvp.Value.Sort();

                foreach (var members in kvp.Value)
                {
                    Console.WriteLine($"! {members}");
                }
            }
        }
    }
}
