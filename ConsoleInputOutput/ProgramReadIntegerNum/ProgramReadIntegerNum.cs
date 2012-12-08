using System;

class ProgramReadIntegerNum
{
    static void Main(string[] args)
    {
        int num = int.Parse(Console.ReadLine());
        int interval = 0;
        if (num > 0)
        {
            for (int i = 0; i < num; i += 1)
            {
                interval += 1;
                Console.WriteLine(interval + "\n");
            }
        }
        else
        {
            Console.WriteLine("Invalid Input!");
        }
    }
}

