using System;

namespace PrintFirstUserName
{
    class PrintUserName
    {
        static void Main()
        {
            PrintFirstName();
        }

        static void PrintFirstName()
        {
            Console.Write("Enter your name : ");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}!", inputName);
        }
    }
}
