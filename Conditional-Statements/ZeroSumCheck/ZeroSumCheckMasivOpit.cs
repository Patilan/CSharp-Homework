using System;
using System.Collections;

namespace ZeroSumCheck
{
    class ZeroSumCheckMasivOpit
    {
        static void Main()
        {
            Console.WriteLine("Summing");

            int[] numbers = { 3, -2, 1, 1, 8 };

            for (int i = 0; i < numbers.Length; i++)
            {
                int current = numbers[i];
                int sum = current;

                Console.WriteLine("Checking for " + current);

                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i == j)
                        continue; // Do not sum with ourselves

                    Console.WriteLine("Summing with " + numbers[j]);
                    sum += numbers[j];
                    if (sum == 0)
                    {
                        break; // 0 sum found
                    }
                } // end for j

                if (sum == 0)
                {
                    Console.WriteLine("Sum is 0!!");
                }

            } // end for i
        }
    }
}
