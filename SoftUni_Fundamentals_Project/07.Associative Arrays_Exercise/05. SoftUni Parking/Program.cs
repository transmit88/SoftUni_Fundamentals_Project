using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> users = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] pards = Console.ReadLine().Split();

                string command = pards[0];

                if (command == "register")
                {
                    string userName = pards[1];
                    string licensePlateNumber = pards[2];

                    if (users.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }

                    else
                    {
                        users.Add(userName, licensePlateNumber);
                        Console.WriteLine($"{userName} registered {licensePlateNumber} successfully");
                    }
                }

                else
                {
                    string userName = pards[1];

                    bool removed = users.Remove(userName);

                    if (removed)
                    {
                        Console.WriteLine($"{userName} unregistered successfully");
                    }

                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                }

            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
