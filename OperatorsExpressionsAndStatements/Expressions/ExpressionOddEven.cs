using System;

class Expressions
{
    static void Main()
    {
        int n = 5;

        if ((n & 1) == 0)
            Console.WriteLine("Even");
        else
            Console.WriteLine("Odd");
    }
}
