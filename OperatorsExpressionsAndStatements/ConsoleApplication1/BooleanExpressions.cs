using System;

    class BooleanExpressions
    {
        static void Main()
        {

            int a = 35;

            if (a % 5 == 0 && a % 7 == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }
    }

