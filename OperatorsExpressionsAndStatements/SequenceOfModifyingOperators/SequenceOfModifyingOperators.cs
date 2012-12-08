using System;

class SequenceOfModifyingOperators
{
    static void Main()
    {
        Console.WriteLine("Enter integer for n = ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter value for v = ");
        int v = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the bit position for p = ");
        int p = int.Parse(Console.ReadLine());
        int mask = 1 << p;
        int checkNumber = n & mask;
        int bit = 1 >> p;
        if (bit != v)
        {
            int theBit = n | mask;
            Console.WriteLine("The new number is = {0}", theBit);
        }
    }   
}