using System;

class ProgramReadsInfo
{
    static void Main(string[] args)
    {
        Console.Write("Company name: ");
        string cName = Console.ReadLine();

        Console.Write("Company adress: ");
        string adress = Console.ReadLine();

        Console.Write("Company PhoneNumber: ");
        int PhoneNum = int.Parse(Console.ReadLine());

        Console.Write("Company fax number: ");
        int fax = int.Parse(Console.ReadLine());

        Console.Write("Company web site: ");
        string web = Console.ReadLine();

        Console.WriteLine("Company manager name: ");
        string managerName = Console.ReadLine();

        Console.WriteLine("Company manager age: ");
        int managerAge = int.Parse(Console.ReadLine());

        Console.WriteLine("Company manager phone number: ");
        int MPhone = int.Parse(Console.ReadLine());
    }
}

