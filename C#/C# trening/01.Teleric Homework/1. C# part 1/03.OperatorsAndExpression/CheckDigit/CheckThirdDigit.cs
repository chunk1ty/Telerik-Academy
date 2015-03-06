using System;

class CheckThirdDigit
{
    static void Main()
    {
        // kato razdelim na 100 poluchavame 17 ( ot uslovieto 1732) sled koeto s %10 vzemame cifrata 7 i sravnqvame 
        // ako iskame da tursim 4 tat cifra delim na 1000 i analogichno za po golemite
        Console.Write("Enter a integer value: ");
        int someValue = int.Parse(Console.ReadLine());
        bool result = ((someValue / 100) % 10)==7;
        Console.WriteLine(result);
    }
}

