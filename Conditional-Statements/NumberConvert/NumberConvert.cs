using System;

namespace NumberConvert
{
    class NumberConvert
    {
        static void Main()
        {
            Console.Write("Type a number:");
            int a = int.Parse(Console.ReadLine());
      

            if ((20 < a) && (a <= 999))
            {   
              int edinici = a % 10;
               int  desetici = (a / 10) % 10;
                int stotici = a / 100;
                Console.WriteLine("{0} {1} {2}", edinici, desetici, stotici);
            }
        }
    }
}
