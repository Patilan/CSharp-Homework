using System;

class MinMaxInteger
{
    static void Main()
    {
        //Write a program that reads from the console a sequence of N integer 
        //numbers and returns the minimal and maximal of them.
                   
        int n, min, max, inputNum;
        Console.Write("Chose how many numbers you want to enter: ");
        n = int.Parse(Console.ReadLine());
            
        if (n <= 0) //if user enters a sequence with negative number or 0
        {
            Console.WriteLine("\nMin=0\nMax=0");
            return;
        }
        else if (1 == n) //if user enters sequence of one number only
        {
            min = max = int.Parse(Console.ReadLine());
        }
        else // if user enters a sequence with n>1 numbers
        {
            min = max = int.Parse(Console.ReadLine());
            for (int i = 1; i < n; i++)
            {
                inputNum = int.Parse(Console.ReadLine());
                min = (min < inputNum) ? min : inputNum;
                max = (max > inputNum) ? max : inputNum;
            }
        }
        Console.WriteLine("\nMin= {0}\nMax= {1}", min, max);
    }
}
