using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            string peopleType = Console.ReadLine();
            string day = Console.ReadLine();

            double price = 0;
            double dicount = 0;
            double totalPrice = 0;

            if (peopleType == "Students")
            {
                if (day == "Friday")
                {
                    price = peopleCount * 8.45;
                }

                else if (day == "Saturday")
                {
                    price = peopleCount * 9.80;
                }

                else if (day == "Sunday")
                {
                    price = peopleCount * 10.46;
                }

                if (peopleCount >= 30)
                {
                    dicount = price * 0.15;
                }
            }

            if (peopleType == "Business")
            {
                if (peopleCount >= 100)
                {
                    peopleCount -= 10;
                }

                if (day == "Friday")
                {
                    price = peopleCount * 10.90;
                }

                else if (day == "Saturday")
                {
                    price = peopleCount * 15.60;
                }

                else if (day == "Sunday")
                {
                    price = peopleCount * 16;
                }
            }

            if (peopleType == "Regular")
            {
                if (day == "Friday")
                {
                    price = peopleCount * 15;
                }

                else if (day == "Saturday")
                {
                    price = peopleCount * 20;
                }

                else if (day == "Sunday")
                {
                    price = peopleCount * 22.50;
                }

                if (peopleCount >= 10 && peopleCount <= 20)
                {
                    dicount = price * 0.05;
                }
            }

            totalPrice = price - dicount;
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
