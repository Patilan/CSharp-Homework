using System;

class CheckInteger
{
    static void Main()
    {
        Console.Write("Enter a number:");
        int number = int.Parse(Console.ReadLine());
        if ((number / 100) % 10 == 7)
        {
            Console.WriteLine("Third number is Seven");
        }
        else
        {
            Console.WriteLine("Third number is not seven");
        }
    }
}
