using System;

namespace QuadraticEquations
{
    class QuadraticEquations
    {
        static void Main()
        {
            // Input value foe the equation a b c
        
        Console.Write("Type the first value a for the quadratic equation a=");
        double a = Double.Parse(Console.ReadLine());
      
        Console.Write("Type the second value b for the quadratic equation b=");
        double b = Double.Parse(Console.ReadLine());
       
        Console.Write("Type the thrid value c for the quadratic equation c=");
        double c = Double.Parse(Console.ReadLine());
    
            // Calculating thr discriminant of the equation

        double d = b * b - 4 * a * c;
          
            // Printing the answer of above

        Console.WriteLine("Discriminant D = " + d.ToString());
            
        if (d < 0) // If the discriminant is <0
        {
        Console.WriteLine("Discriminant is negative and the eqution has no answers.");
        }
        else if (d == 0) // If it equals 0 it has one answer only
        {
        Console.WriteLine("Discriminant is equal to zero so it has only one answer: x = " + ((-b) / (4 * a)).ToString());
        }
        else // If its positive number above zero it has two answers
        {
        Console.WriteLine("x1 = " + ((-b + Math.Sqrt(d)) / (4 * a)).ToString());
        Console.WriteLine("x2 = " + ((-b - Math.Sqrt(d)) / (4 * a)).ToString());
        }

        }
    }
}
