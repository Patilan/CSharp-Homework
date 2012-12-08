using System;

namespace ChooseInpVariable
{
    class ChooseInputVariable
    {
        static void Main()
        {
            Console.WriteLine("Choose a type of variable to enter (integer, double or string):");
            
            int intNumber = 0;
            double doubleNumber = 0;
            string str = "";
            string input;
            string type;

            input = Console.ReadLine();

            if (int.TryParse(input, out intNumber))
            {
                type = "int";
            }
            else if (double.TryParse(input, out doubleNumber))
            {
                type = "double";
            }
            else
            {
                str = input;
                type = "string";
            }

            switch (type)
            {
                case "int": 
                    intNumber += 1; 
                    Console.WriteLine("You choosed to enter an integer:  {0}", intNumber); break;
                case "double":
                    doubleNumber += 1; 
                    Console.WriteLine("You choosed to enter a double:  {0}", doubleNumber); break;
                case "string": 
                    str += "*"; 
                    Console.WriteLine("Your choosed to enter a string:  {0}", str); break;
            }
        }
    }
}
