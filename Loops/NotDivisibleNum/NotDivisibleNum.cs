using System;

class NotDivisibleNum
{
    static void Main()
    {
        //Write a program that prints all the numbers from 1 to N, that are not divisible 
        //by 3 and 7 at the same time.

        Console.Write("Enter a positive integer number: ");
        string consoleArgument = Console.ReadLine();
        uint number = uint.Parse(consoleArgument);
        uint divider1 = 7;
        uint divider2 = 3;
        //If a number is divisible by 2 numbers then the only way it can be divided will
        //be by their production.

        uint maxDivider = divider1 * divider2; 
           
        uint n = 0;
        while (n <= number) 
        {

            if ((n % maxDivider) > 0)
            {
                Console.WriteLine(n);
            }
            // Uncomment the code bellow if you want the divisible numbers to be show with text next to them
            /* 
            else if ((n / maxDivider) > 0)
            {
                Console.WriteLine("{0} is Divisible by 3 and 7", n);
            }
            */
            n++;
              
        }
    }
}
