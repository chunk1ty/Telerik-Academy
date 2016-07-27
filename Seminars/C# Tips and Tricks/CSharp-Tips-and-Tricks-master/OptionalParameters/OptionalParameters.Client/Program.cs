namespace OptionalParameters.Client
{
    using System;

    using OptionalParameters.Library;

    public static class Program
    {
        public static void Main()
        {
            var bankAccount = new BankAccount("John Doe");
            Console.WriteLine(bankAccount);
            Console.ReadLine();
        }
    }
}
