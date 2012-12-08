using System;

class BiggerNum
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine((a > b) ? a : b);
    }
}

