using System;

namespace _04._Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int centuri = int.Parse(Console.ReadLine());

            int centuries = centuri;
            double years = centuri * 100;
            double days =Math.Floor (years * 365.2422);
            double hours = days * 24;
            double minutes = hours * 60;

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes}");
        }
    }
}
