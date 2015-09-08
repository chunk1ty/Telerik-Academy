using System;

class CompanyAndManagerInformation
{
    static void Main()
    {
        Console.WriteLine("Enter a information for a company");
        Console.Write("Name         : ");
        string companyName = Console.ReadLine();
        Console.Write("Address      : ");
        string companyAdress = Console.ReadLine();
        Console.Write("Phone number : ");
        int companyPhoneNumber = int.Parse(Console.ReadLine());
        Console.Write("Fax number   : ");
        int companyFaxNumber = int.Parse(Console.ReadLine());
        Console.Write("Web site     : ");
        string companyWebSite = Console.ReadLine();
        Console.Write("Manager      : ");
        string companyManager = Console.ReadLine ();

        Console.WriteLine("Enter a information for a manager");
        Console.Write("First name   : ");
        string managerFirstName = Console.ReadLine();
        Console.Write("Last name    : ");
        string managerLastName = Console.ReadLine();
        Console.Write("Age          : ");
        byte managerAge = byte.Parse(Console.ReadLine());
        Console.Write("Phone Number : ");
        int managerPhoneNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("                          Information for company");
        Console.WriteLine("Name         : "+companyName);
        Console.WriteLine("Address      : " + companyAdress);
        Console.WriteLine("Phone number : " + companyPhoneNumber);
        Console.WriteLine("Fax number   : " + companyFaxNumber);
        Console.WriteLine("Web site     : " + companyWebSite);
        Console.WriteLine("Manager      : " + companyManager);

        Console.WriteLine("                          Information for a manager");
        Console.WriteLine("First name   : " + managerFirstName);
        Console.WriteLine("Last name    : " + managerLastName);
        Console.WriteLine("Age          : " + managerAge);
        Console.WriteLine("Phone Number : " + managerPhoneNumber);
    }
}
