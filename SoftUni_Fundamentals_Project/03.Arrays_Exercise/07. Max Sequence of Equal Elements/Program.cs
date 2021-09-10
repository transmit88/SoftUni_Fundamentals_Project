using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int counter = 0;
            int winCounter = 0;
            string num = "1";

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    counter++;

                    if (counter > winCounter)
                    {
                        winCounter = counter;
                        num = numbers[i].ToString();
                    }
                    
                }

                else
                {
                    counter = 0;
                }
            }

            for (int i = 0; i <= winCounter; i++)
            {
                Console.Write(num + " ");
            }
        }
    }
}
