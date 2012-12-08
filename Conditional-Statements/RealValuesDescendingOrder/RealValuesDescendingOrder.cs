using System;

namespace RealValuesDescendingOrder
{
    class RealValuesDescendingOrder
    {
        static void Main()
        {
            double a = -75.0000031d;
            double b = 22.23131d;
            double c = -1231.15632;

            //
            if ((a > b) && (a > c))
            {
                if (b > c)
                {
                    Console.WriteLine("{0} > {1} > {2}", a, b, c);
                }
                if (b < c)
                {
                    Console.WriteLine("{0} > {1} > {2}", a, c, b);
                }
            }
            //
            if ((a < b) && (a < c))
            {
                if (b > c)
                {
                    Console.WriteLine("{0} > {1} > {2}", b, c, a);
                }
                if (b < c)
                {
                    Console.WriteLine("{0} > {1} > {2}", c, b, a);
                }
            }
            //
            if ((a < b) && (a > c))
            {
                Console.WriteLine("{0} > {1} > {2}", b, a, c);
            }

            if ((a > b) && (a < c))
            {
                Console.WriteLine("{0} > {1} > {2}", c, a, b);
            }
            

        }
    }
}
