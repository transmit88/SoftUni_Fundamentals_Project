using System;
using System.Collections.Generic;
using System.Linq;


namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int originNumbers = numbers.Count;

            while (true)
            {
                string element = Console.ReadLine();

                if (element == "end")
                {
                    break;
                }

                string[] maniulate = element.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string command = maniulate[0];

                if (command == "Delete")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int maniulateNumber = int.Parse(maniulate[1]);

                        if (numbers[i] == maniulateNumber)
                        {
                            numbers.RemoveAt(i);
                            i -= 1;
                        }

                    }
                }

                if (command == "Insert")
                {
                    int idx =int.Parse(maniulate[2]);
                    int item = int.Parse(maniulate[1]);

                    numbers.Insert(idx, item);
                }

            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
