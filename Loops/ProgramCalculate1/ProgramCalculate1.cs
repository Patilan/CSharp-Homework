using System;

class ProgramCalculate2
{
    static void Main()
    {
        // Write a program that calculates N!/K! for given N and K (1<K<N).

        Console.WriteLine("Enter a number for N = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("\nEnter a number for K = ");
        int k = int.Parse(Console.ReadLine());

        int resultK = 1;
        int resultN = 1;

        // Defines 1 < k < n and calculates factorials for k and n numbers
        if ((1 < k) && (k < n))
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
            
            // Calculates N!/K! and prints result on screen
            int result = resultN / resultK;
            Console.WriteLine("\nResult of N!/K! = {0} \n", result);
        }  //end of loop
        
        // if numbers are not bigger then 1
        else if ((k <= 1) || (n <= 1))
        {
            Console.WriteLine("\nK and N must be bigger then 1\n");
            Main();
        }
        // if n is not bigger then k
        else
        {
            Console.WriteLine("\nN must be bigger then K. Choose again, please!");
            Main();
        }
            

    }
}

