using System;

namespace _01._Encrypt__Sort_and_Print_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] arrayOfSums = new int[count];

            int sum = 0;
            int sumConstant = 0;
            int sumVolwels = 0;
            string vowels = "EeUuIiOoAa";
            

            for (int i = 0; i < count; i++)
            {
                string name = Console.ReadLine();

                for (int j = 0; j < name.Length; j++)
                {
                    char curentLetter = name[j];
                    if (vowels.Contains(curentLetter))
                    {
                        sumVolwels += curentLetter * name.Length;
                    }
                    else
                    {
                        sumConstant += curentLetter / name.Length;
                    }
                }

                sum = sumVolwels + sumConstant;
                arrayOfSums[i] = sum;
                sumVolwels = 0;
                sumConstant = 0;
            }

            Array.Sort(arrayOfSums);

            for (int i = 0; i < arrayOfSums.Length; i++)
            {
                Console.WriteLine(arrayOfSums[i]);
            }
        }
    }
}
