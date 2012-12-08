using System;


class RectangleArea
{
    static void Main()
    {
        string a;
        Console.WriteLine("Enter rectangle side a=");
        a = Console.ReadLine();
        double A = Convert.ToDouble(a);
        
        string b;
        Console.WriteLine("Enter rectangle side b=");
        b = Console.ReadLine();
        double B = double.Parse(b);
        
        double Area = B * A;
        
        Console.WriteLine("Calculated ares is:{0}", Area);
    }
}

