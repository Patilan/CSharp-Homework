using System;

class FibonacciSequence
{
    static void Main()
    {
        decimal f0 = 0;
        decimal f1 = 1;
        decimal sum = 0;
        Console.Write(f0 + "; " + f1 + "; ");
        for (int i = 0; i < 98; i++)
        {
            sum = f0 + f1;
            f0 = f1;
            f1 = sum;
            Console.Write(sum + "; ");
        }
    }
}

