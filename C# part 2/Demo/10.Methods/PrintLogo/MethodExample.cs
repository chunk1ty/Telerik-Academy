using System;

class MethodExample
{
    static void PrintLogo()
    {
        Console.WriteLine("Telerik Corp.");
        Console.WriteLine("www.telerik.com");
    }

    static void PrintAcademyLogo()
    {
        Console.WriteLine("Teleric Academy");
        Console.WriteLine("part of");
        PrintLogo();
    }

    static void Main()
    {
        PrintAcademyLogo();
    }
}
