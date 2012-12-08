using System;

namespace TheBiggestOfThreeInts
{
    class TheBiggestOfThreeInts
    {
        static void Main()
        {

            Console.WriteLine("Enter three numbers to check which one is bigger:");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            // If a is bigger
            if ((a > b) && (a > c))
            {
                if (b == c)
                {
                    Console.WriteLine("{0} is the biggest and {1} and {2} are equal", a, b, c);
                }
                else 
                {
                    Console.WriteLine("{0} is the biggest", a);
                }

            }

            // If b is bigger
            if ((b > a) && (b > c))
            {
                if (a == c)
                {
                    Console.WriteLine("{0} is the biggest and {1} and {2} are equal", b, a, c);
                }
                else 
                {
                    Console.WriteLine("{0} is the biggest", b);
                }
            }

            // If c is bigger
            if ((c > a) && (c > b))
            {
                if (a == b)
                {
                    Console.WriteLine("{0} is the biggest and {1} and {2} are equal", c, a, b);
                }
                else
                {
                    Console.WriteLine("{0} is the biggest", c);
                }
            }
           
            //If b and c are equal and bigger then a
            if ((a < b) && (a < c))
            {

                if (b == c)
                {
                    Console.WriteLine("{0} and {1} are the biggest and equal.", b, c);
                }
            }

            // If a and c are equal and bigger then b
            if ((b < a) && (b < c))
            {
                if (a == c)
                {
                    Console.WriteLine("{0} and {1} are the biggest and equal.", a, c);
                }
            }

            // If a and b are equal and bigger then a
            if ((c < a) && (c < b))
            {
                if (a == b)
                {
                    Console.WriteLine("{0} and {1} are the biggest and equal.", a, b);
                }
            }


            //If all are equal
            if ((a == b) && (a == c))
            {
                Console.WriteLine("{0}, {1}, {2} are equal", a, b, c);

            }
        }
    }
}
