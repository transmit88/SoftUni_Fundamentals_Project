using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            double divide = n * 0.50;
            int target = 0;

            while (n >= m)
            {
                if (n  == divide)
                {
                    if (y > 0)
                    {
                        n /= y;

                        if (n < m)
                        {
                            break;
                        }
                    }
                }

                n -= m;
                target++;
            }

            Console.WriteLine(n);
            Console.WriteLine(target);
           
        }
    }
}
