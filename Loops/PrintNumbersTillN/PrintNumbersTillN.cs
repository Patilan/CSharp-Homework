using System;

class PrintNumbersTillN //Write a program that prints all the numbers from 1 to N.
{
    static void Main()
    {
        Console.WriteLine("Type a number 'till which you want me to print: ");
        int loopNum = int.Parse(Console.ReadLine());
            
        int n = 0;
        // untill i is <= from entered number inscrease i and print it;
        while (n <= loopNum)
        {
            Console.WriteLine(n);
            n++;
        }
    }
}
