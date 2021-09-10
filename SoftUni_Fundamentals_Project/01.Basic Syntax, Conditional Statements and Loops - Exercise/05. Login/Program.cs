using System;
using System.Linq;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            string password = "";

            for (int i = userName.Length - 1; i >= 0 ; i--)
            {
                password += userName[i];
            }

            string tryPassword = Console.ReadLine();
            int couter = 0;

            while (tryPassword != password)
            {

                couter +=1;
                if (couter == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
                tryPassword = Console.ReadLine();

            }

            if (couter < 4)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
        }

    }
}
