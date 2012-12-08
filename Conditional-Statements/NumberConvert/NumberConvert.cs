using System;

namespace NumberConvert
{
    class NumberConvert
    {
        static void Main()
        {
            Console.Write("Type a number between 0 and 999:");
            string inp = Console.ReadLine(); // read inpuut

            //define a single dimensional string array with basic digits
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eignt", "nine" };
            
            int inpNumber; // define input number


            if (!int.TryParse(inp, out inpNumber)) //if user does not enter valid number
            {
                Console.WriteLine("This is not a number");
            }
            if ((inpNumber < 0) || (inpNumber > 999)) //if user enter a number diff from 0 to 999
            {
                Console.WriteLine("Enter a number thats is between 0 and 999, please.");
            }
                
            //Number checking and printing

            //Number is smaller then 10
            if (inpNumber < 10)
            { 
            Console.WriteLine(digits[inpNumber]);
            }

            //Number between 10 and 20
            if ((10 <= inpNumber) && (inpNumber < 20))
            {
                switch (inpNumber)
                {
                    case 10:
                        Console.WriteLine("Ten");
                        break;
                    case 11:
                        Console.WriteLine("Eleven");
                        break;
                    case 12:
                        Console.WriteLine("Twelve");
                        break;
                    case 13:
                        Console.WriteLine("Thirteen");
                        break;
                    case 15:
                        Console.WriteLine("Fifteen");
                        break;

                    default:
                        int edinici = inpNumber % 10; 
                        Console.WriteLine(digits[edinici]+ "teen");
                        break;
                }
 
            } //end of 10 to 20

            //Numbers between 20 and 99
            if ((inpNumber >= 20) && (inpNumber <= 99))
            {
                int desetici = inpNumber / 10;
                int edinici = inpNumber % 10;

                switch (desetici)
                {
                    case 2:
                        if (edinici > 0)
                        {
                            Console.WriteLine("twenty-" + digits[edinici]);
                        }
                        else
                        {
                           Console.WriteLine("twenty");
                        }
                        break;
                    case 3:
                        if (edinici > 0)
                        {
                            Console.WriteLine("thirty-" + digits[edinici]);
                        }
                        else
                        {
                            Console.WriteLine("thirty");
                        }
                        break;
                    case 5:
                        if (edinici > 0)
                        {
                            Console.WriteLine("fifty-" + digits[edinici]);
                        }
                        else
                        {
                            Console.WriteLine("fifty");
                        }
                        break;
                    
                    default:
                        if (edinici > 0)
                        {
                            Console.WriteLine(digits[desetici]+"ty-"+ digits[edinici]);
                        }
                        else
                        {
                            Console.WriteLine(digits[desetici]+"ty");
                        }
                        break;
                }
            } //end of 20 to 99
           
            //Numbers between 99 and 999
            if ((inpNumber > 99) && (inpNumber <= 999))
            {
                int desetici = (inpNumber / 10) % 10;
                int edinici = inpNumber % 10;
                int hundreds = inpNumber / 100;
            
                if ((edinici == 0) && (desetici == 0)) //begin hundreds only
                {
                Console.WriteLine(digits[hundreds] + " hundred");
                } // end hundreds only

                else if ((edinici > 0) && (desetici == 0)) // begin for all hundreds and edinici
                {
                    Console.WriteLine(digits[hundreds] + " hundred and " + digits[edinici]);
                } //end for all hundreds and edinici

                else if ((edinici > 0) && (desetici == 1)) // begin for 10 to 20 for all hundreds
                {
                    switch (desetici)
                    {
                        case 1:
                            Console.WriteLine(digits[hundreds] + " hundred and eleven");
                            break;
                        case 2:
                            Console.WriteLine(digits[hundreds] + " hundred and twelve");
                            break;
                        case 3:
                            Console.WriteLine(digits[hundreds] + " hundred and thirteen");
                            break;
                        case 5:
                            Console.WriteLine(digits[hundreds] + " hundred and fifteen");
                            break;
                        default:
                            Console.WriteLine(digits[hundreds] + " hundred and " + digits[desetici] + "teen");
                            break;
                    }
                        
                } //end of 10 to 20 for all hundreds

                // begind for all 20;30;40;50.... of hundreds
                else if ((edinici == 0) && (desetici > 0))
                {
                    switch (desetici)
                    {
                        case 1:
                            Console.WriteLine(digits[hundreds] + " hundred and ten");
                            break;
                        case 2:
                            Console.WriteLine(digits[hundreds] + " hundred and twenty");
                            break;
                        case 3:
                            Console.WriteLine(digits[hundreds] + " hundred and thirty");
                            break;
                        case 5:
                            Console.WriteLine(digits[hundreds] + " hundred and fifty");
                            break;
                        default:
                            Console.WriteLine(digits[hundreds] + " hundred and " + digits[desetici] + "ty");
                            break;
                    }
                }   //end for all 20;30;40;50.... of hundreds
                 
                    //begin for 22;23;24....99; of all hundreds 
                else if ((edinici > 0) && (desetici > 1))

                {
                    switch (desetici)
                    {
                        case 2:
                            Console.WriteLine(digits[hundreds] + " hundred and twenty-" + digits[edinici]);
                            break;
                        case 3:
                            Console.WriteLine(digits[hundreds] + " hundred and thirty-" + digits[edinici]);
                            break;
                        case 5:
                            Console.WriteLine(digits[hundreds] + " hundred and fifty-" + digits[edinici]);
                            break;
                        default:
                            Console.WriteLine(digits[hundreds] + " hundred and " + digits[desetici] + "ty-" + digits[edinici]);
                            break;

                    }
                }   // end for 22;23;24....99; of all hundreds
            
            } //end for numbers between 99 and 999

        }
    }
}
