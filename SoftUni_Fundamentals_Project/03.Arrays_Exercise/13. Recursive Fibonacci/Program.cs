using System;

namespace _13._Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int nFibonacci = int.Parse(Console.ReadLine());
            int n1 = 1;
            int n2 = 1;
            int n3 = nFibonacci;
            if (nFibonacci <= 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 2; i < nFibonacci; i++)
                {
                    n3 = n1 + n2;
                    
                    n1 = n2;
                    n2 = n3;
                }
                Console.Write(n3);
            }
            
        }
    }
}
