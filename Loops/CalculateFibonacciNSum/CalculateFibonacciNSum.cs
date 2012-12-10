using System;


class CalculateFibonacciNSum
{
    static void Main()
            {

        //Write a program that reads a number N and calculates the sum of the first N
        //members of the sequence of 
        //Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

        Console.Write("Type the N: ");
        int fibonacciN = int.Parse(Console.ReadLine());
        int sum = 0;
        int firstNum = 0;
        int secondNum = 1;
        int sumNum;


        for (int i = 1; i <= (fibonacciN -2); i++)
        {

           sumNum = firstNum + secondNum;
           firstNum= secondNum;
           secondNum = sumNum;
           sum += (sumNum);
            
        }
        
        Console.WriteLine("\nThe sum of sequence with {0} numbers of Fibonacci is equal to {1}", fibonacciN, sum+1);
       
    }
}
