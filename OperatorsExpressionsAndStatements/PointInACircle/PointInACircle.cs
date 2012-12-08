using System;

class PointInACircle
{
    static void Main()
    {
        double X = double.Parse(Console.ReadLine());
        double Y = double.Parse(Console.ReadLine());
        double radius = 5;

        bool formulaForResult = (X * X) + (Y * Y) <= radius * radius;

        Console.WriteLine(formulaForResult ? "The point with coordinates \"{0},{1}\" is inside the circle" :
            "The point with coordinates \"{0},{1})\" is not inside the circle", X, Y);

    }
}

