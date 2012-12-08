using System;

    class DeclareStringVariables
    {
        static void Main()
        {
            string h = "Hello";
            string w = "world!";

            object combine = h + ", " + w ;

            string combinesentence = (string)combine;

            Console.WriteLine(combinesentence);
        }
    }
