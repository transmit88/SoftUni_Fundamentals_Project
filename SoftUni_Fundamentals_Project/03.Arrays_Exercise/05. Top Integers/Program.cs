using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0 ; i < numArr.Length; i++)
            {
                bool isItBigger = true;

                for (int j = i + 1 ; j < numArr.Length; j++)
                {

                    if(numArr[i] <= numArr[j])
                    {
                        isItBigger = false;
                        break;
                    }
                }

                if (isItBigger)
                {
                    Console.Write(numArr[i] + " ");
                }
            }
        }
    }
}
