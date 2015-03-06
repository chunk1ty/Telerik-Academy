using System;

class PointIsWithinCircle
{
    static void Main()
    {
        decimal pointX = decimal.Parse(Console.ReadLine());
        decimal pointY = decimal.Parse(Console.ReadLine());
        Console.WriteLine((pointX*pointX+pointY*pointY)<25? "In":"Out");
    }
}
