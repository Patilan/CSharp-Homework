using System;

namespace ShowPlusOrMinusSign
{
    class ShowPlusOrMinusSign
    {
        static void Main()
        {

            double a = 5.31d;
            double b = 22.23d;
            double c = 12.1532;

            if (((a > 0) && (b < 0)) && (c > 0))
            {
                Console.WriteLine("The product will be negative: -");
            }
            else if (((a > 0) && (b > 0)) && (c < 0))
            {
                Console.WriteLine("The product will be negative: -");
            }
            else if ((a > 0) && ((b < 0) && (c < 0)))
            {
                Console.WriteLine("The product will be positive: +");
            }
            else if ((a < 0) && ((b < 0) && (c < 0)))
            {
                Console.WriteLine("The product will be negative: -");
            }
            else if ((a < 0) && ((b < 0) && (c > 0)))
            {
                Console.WriteLine("The product will be positive: +");
            }
            else if ((a < 0) && ((b > 0) && (c < 0)))
            {
                Console.WriteLine("The product will be positive: +");
            }
            else if ((a > 0) && ((b > 0) && (c > 0)))
            {
                Console.WriteLine("The product will be positive: +");
            }
        }
    }
}
