using System;


    class BankAccount
    {
        static void Main()
        {
          
            string holderName = "Dimitar " + "Georgiev " + "Petrov";

            int moneyAmount = 2046338900 ;
            string bankName = "Първа Селска Банка";
            string iban = "BG1231231USFA634534";
            string bic = "GRASGHH";
            uint ccnumber1 = 123456789;
            uint ccnumber2 = 123456789;
            uint ccnumber3 = 123456789;

            Console.WriteLine("Full Name: {0}\nBalance: {1}\nBank: {2}\nIBAN: {3}\nBIC: {4}\nCredit Card Numbers:\n1.{5}\n2.{6}\n3.{7} ", holderName, moneyAmount, bankName, iban, bic, ccnumber1, ccnumber2, ccnumber3);
        }
    }

