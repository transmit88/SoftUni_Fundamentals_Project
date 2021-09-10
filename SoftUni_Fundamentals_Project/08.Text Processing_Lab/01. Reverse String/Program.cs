using System;
using System.Linq;

namespace Text_Processing___Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string reverse = string.Empty;

            while (name != "end")
            {

                for (int i = name.Length - 1; i >= 0; i--)
                {
                    reverse += name[i];

                }

                Console.WriteLine($"{name} = {reverse}");
                reverse = string.Empty;
                name = Console.ReadLine();
            }

        }
    }
}
