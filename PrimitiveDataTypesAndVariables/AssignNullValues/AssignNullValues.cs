using System;

    class AssignNullValues
    {
        static void Main()
        {
            int? Int = null; //задава null стойност на Int
            Console.WriteLine(Int); //изкарва стойността по подразбиране
            double? Double = null; // Задава null стойност на Double 
            Console.WriteLine(Double); //изкарва стойността по подразбиране

            Int = 2;   //ако се зададе стойност тук на кода на долния ред ще бъде изкаранa в конзолата
            Console.WriteLine(Int.GetValueOrDefault()); //Изкарва стойността по подразбиране ако не е въведена такава в горния ред
            Int = null;   //ако се зададе стойност тук на кода на долния ред ще бъде изкаранa в конзолата
            Console.WriteLine(Int.GetValueOrDefault()); //Изкарва стойността по подразбиране ако не е въведена такава в горния ред
            Double = 4; //ако се зададе стойност тук на кода на долния ред ще бъде изкаран в конзолата
            Console.WriteLine(Double.GetValueOrDefault()); //Изкарва стойността по подразбиране ако не е въведена такава в горния ред
            Double = null; //ако се зададе стойност тук на кода на долния ред ще бъде изкаран в конзолата
            Console.WriteLine(Double.GetValueOrDefault()); //Изкарва стойността по подразбиране ако не е въведена такава в горния ред
        }
    }

