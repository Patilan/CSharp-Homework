using System;

class ProgramCalculate3
{
    static void Main()
    {
        //Write a program that, for a given two integer numbers N and X, calculates 
        //the sumS = 1 + 1!/X + 2!/X^2 + … + N!/X^N

        Console.Write("Enter a number for N = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("\nEnter a number for X = ");
        int x = int.Parse(Console.ReadLine());

        int resultX;
        int resultN;
        double sum = 1;
        
        for (int i = 1; i <= n; i++)
        {
            resultN = 1;
            resultX = 1;
            for (int j = 1; j <= i; j++)
            {
                resultN *= j; //counts the n factoriel defined by j cycle and saves the product in it
                resultX *= x; // * x with x every j cycle and saves the product in it
            }
            //end of j cycle sums every factoriel/x from the sequence and saves it in sum
            sum += (double)(resultN) / (double)(resultX); 
            
        } //goes to i to check if its = n it its not repeats j cycle if not goes down the road

        Console.WriteLine("\nThe sum of \nS = 1 + 1!/X + 2!/X^2 + ... + N!/X^N \nis {0}", sum);
        
    
    }
}
