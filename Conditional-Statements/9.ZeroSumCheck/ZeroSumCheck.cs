using System;

namespace ZeroSumCheck
{
    class ZeroSumCheck
    {
        static void Main()
        {
            Console.WriteLine("Enter five numbers(A,B,C,D,E) to check if their subset can have a sum of 0:");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int sum = 0;
            
            //Subset sums of the five numbers

            if (sum == (a + b))
            {
                 Console.WriteLine("A + B = 0");
            }
            if (sum == (a + c))
            {
                 Console.WriteLine("A + C = 0");
            }
            if (sum == (a + d))
            {
                Console.WriteLine("A + D = 0");
            }
            if (sum == (a + e))
            {
                Console.WriteLine("A + E = 0");
            }
            if (sum == (b + c))
            {
                Console.WriteLine("B + C = 0");
            }
            if (sum == (b + d))
            {
                Console.WriteLine("B + D = 0");
            }
            if (sum == (b + e))
            {
                Console.WriteLine("B + E = 0");
            }
            if (sum == (c + d))
            {
                Console.WriteLine("C + D = 0");
            }
            if (sum == (d + e))
            {
                Console.WriteLine("D + E = 0");
            }
            if (sum == (a + b + c))
            {
                Console.WriteLine("A + B + C = 0");
            } 
            if (sum == (a + b + d))
            {
                Console.WriteLine("A + B + D = 0");
            }
            if (sum == (a + b + e))
            {
                Console.WriteLine("A + B + E = 0");
            }
            if (sum == (a + c + d))
            {
                Console.WriteLine("A + C + D = 0");
            }
            if (sum == (a + c + e))
            {
                Console.WriteLine("A + C + E = 0");
            }
            if (sum == (a + d + e))
            {
                Console.WriteLine("A + D + E = 0");
            }
            if (sum == (b + c + d))
            {
                Console.WriteLine("B + C + D = 0");
            }
            if (sum == (b + c + e))
            {
                Console.WriteLine("B + C + E = 0");
            }
            if (sum == (b + d + e))
            {
                Console.WriteLine("B + D + E = 0");
            }
            if (sum == (a + b + c + d))
            {
                Console.WriteLine("A + B + C + D = 0");
            }
            if (sum == (a + b + c + e))
            {
                Console.WriteLine("A + B + C + E = 0");
            }
            if (sum == (a + c + d + e))
            {
                Console.WriteLine("A + C + D + E = 0");
            }
            if (sum == (a + b + d + e))
            {
                Console.WriteLine("A + B + D + E = 0");
            }
            if (sum == (b + c + d + e))
            {
                Console.WriteLine("B + C + D + E = 0");
            }
            if (sum == (a + b + c + d + e))
            {
                Console.WriteLine("A + B + C + D = 0");
            } 
        }
    }
}
