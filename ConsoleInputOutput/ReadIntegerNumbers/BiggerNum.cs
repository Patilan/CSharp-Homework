﻿using System;

class ReadIntegerNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine(Math.Max(a, b));
    }
}
