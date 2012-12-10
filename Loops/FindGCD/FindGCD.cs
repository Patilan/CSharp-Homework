using System;

class FindGCD
{
    static void Main()
    {
        //Write a program that calculates the greatest common divisor (GCD) of given two numbers

        Console.Write("First number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Second number: ");
        int b = int.Parse(Console.ReadLine());

        // Finding the GCD loop
        while ((a > 0) && (b > 0))
        {
            if (a > b)
            {
                a %= b; 
            }
            else
            {
                b %= a;
            }
            
        } // end of loop

        //Get the GCD number on screen
        if (a > b)
        {
            Console.WriteLine("\nGCD is {0}", a);

        }
        else if (b > a)
        {
            Console.WriteLine("\nGCD is {0}", b);
        }

    }
}
