using System;

class PointInCircleRecangle
{
    static void Main()
    {
        Console.Write("Enter x= ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Enter y= ");
        double y = double.Parse(Console.ReadLine());

        bool withinCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9;

        bool withinRectangle = ((-1 <= x) && (x <= 5)) && ((-1 <= y) && (y <= 1));

        Console.Write("Your point is ");
        Console.Write(withinCircle ? "within the circle and " : "outside of the circle and ");
        Console.WriteLine(withinRectangle ? "within the rectangle." : "outside of the rectangle.");
    }
}

