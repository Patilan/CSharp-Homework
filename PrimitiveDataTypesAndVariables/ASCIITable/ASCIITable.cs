using System;

class ASCIITable
{
    static void Main()
    {
        int i = 0;

        while (i <= 127)
        {
            Console.WriteLine((char)i);
            i++;
        }
    }
}
