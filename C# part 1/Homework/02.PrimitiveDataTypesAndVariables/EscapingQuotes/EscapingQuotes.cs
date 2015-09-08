using System;

class EscapingQuotes
{
    static void Main()
    {
        //The "use" of quotations causes difficulties.
        Console.WriteLine(@"The ""use"" of quotations causes difficulties.");
        Console.WriteLine("The \"use\" of quotations causes difficulties.");
    }
}

