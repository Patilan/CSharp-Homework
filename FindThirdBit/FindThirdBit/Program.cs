using System;

class FindThirdBit
{
    static void Main()
    {
        Console.Write("Enter number = ");
        int number = int.Parse(Console.ReadLine());
        int numberBitwised = (number >> 3);
        int thirdBit = numberBitwised % 2;
        if (thirdBit == 1)
        {
            Console.WriteLine("The third bit is 1");
        }
        else
        {
            Console.WriteLine("The third bit is 0");
        }
    }
}

