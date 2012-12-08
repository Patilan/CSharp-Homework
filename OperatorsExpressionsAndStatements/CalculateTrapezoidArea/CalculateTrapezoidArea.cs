using System;

    class CalculateTrapezoidArea
    {
        static void Main()
        {
            Console.Write("a= ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b= ");

            float b = float.Parse(Console.ReadLine());
            Console.Write("h= ");

            float h = float.Parse(Console.ReadLine());
            double area;
 
            Console.WriteLine("Formula -> Area = ((a + b) / 2) * h");
            area = ((a + b) / 2) * h;

            Console.WriteLine("And the area of the trapezoid is= {0}", area);
        }
    }

