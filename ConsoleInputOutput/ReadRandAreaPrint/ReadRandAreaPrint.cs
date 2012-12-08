using System;

class ReadRandAreaPrint
{
    static void Main()
    {
        Console.WriteLine("Enter a value for the radius of the circle.");

        Console.Write("r = ");

        string rstr = Console.ReadLine();
        int r = int.Parse(rstr);
        double pi = 3.14;
        double perimeter = (2 * pi) * r;
        double area = pi * (r * r);

        Console.WriteLine("Circle with radius r={0} has area equal to {1} and perimeter equal to {2}.", r, area, perimeter);
    }
}

