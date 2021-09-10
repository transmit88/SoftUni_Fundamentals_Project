using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var length = double.Parse(Console.ReadLine());
            var width = double.Parse(Console.ReadLine());
            var height = double.Parse(Console.ReadLine());

            var volume = (length * width * height) / 3;
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:F2}");
        }
    }
}
