using System;

namespace Conditional_Statements
{
    class Conditional_Statements
    {
        static void Main()
        {
            Console.WriteLine("Enter two numbers.");

            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int three = new int();

            if (firstNumber > secondNumber)
            {
                three = secondNumber;
                secondNumber = firstNumber;
                firstNumber = three;
                Console.WriteLine("First number {0} was exchanged with the second {1}",
                secondNumber, firstNumber);
            }


            else
            {
                Console.WriteLine("Your first number have to be bigger then the Second one!");
            }
        }
    }
}
