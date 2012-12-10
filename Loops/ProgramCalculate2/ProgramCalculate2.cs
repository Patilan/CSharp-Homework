using System;

class Program
{
    static void Main()
    {
        //Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

        Console.WriteLine("Enter a number for N = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("\nEnter a number for K = ");
        int k = int.Parse(Console.ReadLine());

        int resultK = 1;
        int resultN = 1;
        int resultKN = 1;
        int factKN = k - n; 

        // Defines 1 < N < K
        if ((1 < n) && (n < k))
        {
            while (1 < k)
            {
                resultK *= k;
                k--;
            }
            while (1 < n)
            {
                resultN *= n;
                n--;
            }
            while (factKN > 0)
            {
                resultKN *= factKN;
                factKN--;
            }
            //Calculates formula and prints result
            int result = (resultN * resultK) / resultKN;
            Console.WriteLine("\nResult of (N!*K!) / (K-N)! = {0} \n", result);
        }// End of loop 

        //if K and N are not bigger then 1
        else if ((k <= 1) || (n <= 1))
        {
            Console.WriteLine("\nK and N must be bigger then 1\n");
            Main();
        }
        //If K is not bigger then N 
        else
        {
            Console.WriteLine("\nK must be bigger then N. Choose again, please!");
            Main();
        }
    }
}

