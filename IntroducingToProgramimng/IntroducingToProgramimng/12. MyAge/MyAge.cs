using System;

    class MyAge
    {
        static void Main()
        {
            Console.WriteLine("Write your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("In ten years your age will be {0}. ", age + 10);
        }
    }
