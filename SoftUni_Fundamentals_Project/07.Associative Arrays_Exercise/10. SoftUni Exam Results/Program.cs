using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users = new Dictionary<string, List<string>>();
            Dictionary<string, int> languages = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "exam finished")
                {
                    break;
                }

                string[] pats = input.Split("-",StringSplitOptions.RemoveEmptyEntries);

                string name = pats[0];
                string language = pats[1];

                if (language == "banned")
                {
                    users[name][1] = "banned";
                }

                else
                {
                    int score = int.Parse(pats[2]);

                    if (users.ContainsKey(name))
                    {
                        if (int.Parse(users[name] [1]) < score)
                        {
                            users[name][1] = score.ToString();
                        }
                    }

                    else
                    {
                        users.Add(name, new List<string> {language, score.ToString()});
                    }

                    if (languages.ContainsKey(language))
                    {
                        languages[language]++;
                    }

                    else
                    {
                        languages.Add(language, 1);
                    }
                }
            }

            Console.WriteLine("Results:");

            var sortedUserResult = users
                .Where(x => x.Value[1] != "banned")
                .OrderByDescending(x => x.Value[1])
                .ThenBy(x => x.Key);

            foreach (var user in sortedUserResult)
            {
                Console.WriteLine($"{user.Key} | {user.Value[1]}");
            }

            Console.WriteLine("Submissions:");

            var sortedLanguages = languages
                .OrderByDescending(x => x.Value)
                .ThenBy(x => x.Key);
           
            foreach (var item in sortedLanguages)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}
