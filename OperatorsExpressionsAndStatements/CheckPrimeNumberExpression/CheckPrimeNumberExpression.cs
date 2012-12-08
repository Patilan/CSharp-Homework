using System;

    class CheckPrimeNumberExpression
    {
        static void Main()
        {
            Console.Write("Enter a positive number bewtween 1 and 100, n=");
            uint n = uint.Parse(Console.ReadLine());
            bool a = true;
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("n={0} is not a prime number", n);
                    a = false;
                    break;
                }
            }
            if (a == true)
            {
                Console.WriteLine("n={0} is a prime number", n);
            }
            
        }
    }

