using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountOfMOney = double.Parse(Console.ReadLine());
            double countOfStudents = double.Parse(Console.ReadLine());
            double priceOfLightsabers = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double percentStudent = Math.Ceiling(countOfStudents * 0.10);
            double sarbesPrice = priceOfLightsabers * (countOfStudents + percentStudent);
            double robesPrice = priceOfRobes * countOfStudents;

            double discount = 0;
            for (int i = 6; i <= countOfStudents; i += 6)
            {
                if (i % 6 == 0)
                {
                    discount++;
                }
            }

            countOfStudents -= discount;
            double beltsPrice = priceOfBelts * countOfStudents;

            double totalPrice = beltsPrice + robesPrice + sarbesPrice;

            if(amountOfMOney >= totalPrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }

            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalPrice - amountOfMOney):F2}lv more.");
            }
        }
    }
}
