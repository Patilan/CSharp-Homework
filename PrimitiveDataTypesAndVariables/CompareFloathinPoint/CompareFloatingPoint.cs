using System;

    class CompareFloatingPoint
    {
        static void Main()
        {
            float a = 5.3f;
            float b = 6.01f;
            if (a == b)
              Console.WriteLine("{0} is equal to {1}", 5.3, 6.01);
            else
              Console.WriteLine("{0} is not equal to {1}", 5.3, 6.01);

            float c = 5.00000001f;
            float d = 5.00000003f;
            if (c == d)
                Console.WriteLine("{0} is equal to {1}", 5.00000001, 5.00000003);
            else
                Console.WriteLine("{0} is not equal to {1}", 5.00000001, 5.00000003);
        }
    }
