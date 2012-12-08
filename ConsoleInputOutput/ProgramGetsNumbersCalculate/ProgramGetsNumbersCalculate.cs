using System;

class ProgramGetsNumbersCalculate
{
    static void Main()
    {
        Console.Write("How many numbers do you want to sum: ");
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Enter number: ");
            sum += double.Parse(Console.ReadLine());
        }
        Console.WriteLine("The calculated sum is: {0}", sum);
    }
}
