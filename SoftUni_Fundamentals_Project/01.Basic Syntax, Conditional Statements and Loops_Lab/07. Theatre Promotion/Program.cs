using System;

namespace _07._Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            var typeOfDay = Console.ReadLine().ToLower();
            var agePerson = int.Parse (Console.ReadLine());
            var price = 0;

            if (typeOfDay == "weekday")
            {
                if ( agePerson >= 0 && agePerson <= 18 || (agePerson > 64 && agePerson <= 122))
                {
                    price = 12;
                }

                else if (agePerson >= 18 && agePerson <= 64)
                {
                    price = 18;
                }
            }

            else if (typeOfDay == "weekend")
            {
                if (agePerson >= 0 && agePerson <= 18 || (agePerson > 64 && agePerson <= 122))
                {
                    price = 15;
                }

                else if (agePerson >= 18 && agePerson <= 64)
                {
                    price = 20;
                }
            }

            else if (typeOfDay == "holiday")
            {
                if (agePerson >= 0 && agePerson <= 18)
                {
                    price = 5;
                }

                else if (agePerson > 18 && agePerson <= 64)
                {
                    price = 12;
                }

                else if (agePerson > 64 && agePerson <= 122)
                {
                    price = 10;
                }
            }

            if (price != 0)
            {
                Console.WriteLine($"{price}$");
            }

            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
