using System;
using System.Collections.Generic;

namespace BiggestOfFiveInts
{
    class BiggestOfFiveInts
    {
        static void Main()
        {
             Console.WriteLine("Enter five numbers to check which one is bigger:");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());

                int max = 0;

                if (a > b)
                {
                    max = a;
                    if (max > c)
                    {
                        if (max > c)
                        {
                            if (max > d)
                            {
                                Console.WriteLine(max);
                            }
                            else
                            {
                                Console.WriteLine(d);
                            }
                        }
                        else
                        {
                            max = d;
                            if (max > e)
                            {
                                Console.WriteLine(max);
                            }
                            else
                            {
                                Console.WriteLine(e);
                            }
                        }
                    }
                    else
                    {
                        max = c;
                        if (max > d)
                        {
                            if (max > e)
                            {
                                Console.WriteLine(max);
                            }
                            else
                            {
                                Console.WriteLine(e);
                            }
                        }
                        else
                        {
                            max = d;
                            if (max > e)
                            {
                                Console.WriteLine(max);
                            }
                            else
                            {
                                Console.WriteLine(e);
                            }
                        }
                    }
                }
                else
                {
                    max = b;
                    if (max > c)
                    {
                        if (max > d)
                        {
                            if (max > e)
                            {
                                Console.WriteLine(max);
                            }
                            else
                            {
                                Console.WriteLine(e);
                            }
                        }
                        else
                        {
                            max = d;
                            if (max > e)
                            {
                                Console.WriteLine(max);
                            }
                            else
                            {
                                Console.WriteLine(e);
                            }
                        }
                    }
                    else
                    {
                        max = c;
                        if (max > d)
                        {
                            if (max > e)
                            {
                                Console.WriteLine(max);
                            }
                            else
                            {
                                Console.WriteLine(e);
                            }
                        }
                        else
                        {
                            max = d;
                            if (max > e)
                            {
                                Console.WriteLine(max);
                            }
                            else
                            {
                                Console.WriteLine(e);
                            }
                        }
                    }
            }
        }
    }
}
