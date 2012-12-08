using System;

class ExpressionExtractsBit
{
    static void Main()
    {
        Console.Write("Enter a number= ");
        int i = int.Parse(Console.ReadLine());

        Console.Write("Enter a bit number= ");
        int b = int.Parse(Console.ReadLine());

        int mask = 1 << b;
        int iAndMask = i & mask;
        int theBit = iAndMask >> b;
        Console.WriteLine("The value of bit {0} from the number {1} is {2}", b, i, theBit);
    }
}

