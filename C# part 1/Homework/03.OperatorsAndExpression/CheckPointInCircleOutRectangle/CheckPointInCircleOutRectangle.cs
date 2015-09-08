using System;

class CheckPointInCircleOutRectangle
{
    static void Main()
    {
        //(x - center_x)^2 + (y - center_y)^2 < radius^2
        decimal pointX = decimal.Parse(Console.ReadLine());
        decimal pointY = decimal.Parse(Console.ReadLine());

        bool isInCircle = ((pointX-1) * (pointX-1) + (pointY-1) * (pointY-1)) < 9;
        bool isInRectangle = ((pointX < -1) || (pointX > 5)) || ((pointY < 1) || (pointY > 5));

        Console.WriteLine(isInCircle ? "In Circle" : "Out Circle");
        Console.WriteLine(isInRectangle ? "Out Rectangle" : "In Rectangle");
    }
}

