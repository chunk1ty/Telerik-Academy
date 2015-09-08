using System;

class PerimeterAndAreaOfCircle
{
    static void Main()
    {
        Console.Write("Enter a radius: ");
        decimal radiusR = decimal.Parse(Console.ReadLine());                  //Convert.ToDecimal(Console.ReadLine());
        decimal pi = 3.14159265359M;

        Console.WriteLine("The perimeter of Circle is : "+(pi*radiusR*2) );
        Console.WriteLine("The area of Circle is : " + (pi * radiusR * radiusR));
        
    }
}

