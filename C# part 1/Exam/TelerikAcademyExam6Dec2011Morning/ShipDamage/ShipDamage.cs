using System;

class ShipDamage
{
    static void Main()
    {
        int rectangleFirstPointX = int.Parse(Console.ReadLine());
        int rectangleFirstPointY = int.Parse(Console.ReadLine());
        int rectangleSecondPointX = int.Parse(Console.ReadLine());
        int rectangleSecondPointY = int.Parse(Console.ReadLine());

        int horisont = int.Parse(Console.ReadLine());

        int firstShotX = int.Parse(Console.ReadLine());
        int firstShotY = int.Parse(Console.ReadLine());
        int secondShotX = int.Parse(Console.ReadLine());
        int secondShotY = int.Parse(Console.ReadLine());
        int thirdShotX = int.Parse(Console.ReadLine());
        int thirdShotY = int.Parse(Console.ReadLine());

        firstShotY = 2 * horisont - firstShotY;
        secondShotY = 2 * horisont - secondShotY;
        thirdShotY = 2 * horisont - thirdShotY;

        int xMin = Math.Min(rectangleFirstPointX,rectangleSecondPointX);
        int xMax = Math.Max(rectangleFirstPointX, rectangleSecondPointX);
        int yMin = Math.Min(rectangleFirstPointY, rectangleSecondPointY);
        int yMax = Math.Max(rectangleFirstPointY, rectangleSecondPointY);

        int sum = 0;

        if ((firstShotX > xMin) && (firstShotX < xMax) && (firstShotY > yMin) && (firstShotY < yMax))
        {
            sum += 100;
        }
        else if (((((firstShotX > xMin) && (firstShotX < xMax) && (firstShotY == yMax)) || ((firstShotY > yMin) && (firstShotY < yMax) && (firstShotX == xMax)) || ((firstShotX > xMin) && (firstShotX < xMax) && (firstShotY == yMin)) || (firstShotY > yMin) && (firstShotY < yMax) && (firstShotX == xMin))))
        {
            sum += 50;
            
        }
        else if (((firstShotX == xMin) && (firstShotY == yMax)) || ((firstShotX == xMax) && (firstShotY == yMax)) || ((firstShotX == xMax) && (firstShotY == yMin)) || ((firstShotX == xMin) && (firstShotY == yMin)))
        {
            sum += 25;
        }
        else
        {
            sum += 0;
        }

        if ((secondShotX > xMin) && (secondShotX < xMax) && (secondShotY > yMin) && (secondShotY < yMax))
        {
            sum += 100;
        }
        else if ((((secondShotX > xMin) && (secondShotX < xMax) && (secondShotY == yMax)) || ((secondShotY > yMin) && (secondShotY < yMax) && (secondShotX == xMax)) || ((secondShotX > xMin) && (secondShotX < xMax) && (secondShotY == yMin)) || (secondShotY > yMin) && (secondShotY < yMax) && (secondShotX == xMin)))
        {
            sum += 50;
        }
        else if (((secondShotX == xMin) && (secondShotY == yMax)) || ((secondShotX == xMax) && (secondShotY == yMax)) || ((secondShotX == xMax) && (secondShotY == yMin)) || ((secondShotX == xMin) && (secondShotY == yMin)))
        {
            sum += 25;
        }
        else
        {
            sum += 0;
        }

        if ((thirdShotX > xMin) && (thirdShotX < xMax) && (thirdShotY > yMin) && (thirdShotY < yMax))
        {
            sum += 100;
        }
        else if (((thirdShotX > xMin) && (thirdShotX < xMax) && (thirdShotY == yMax)) || ((thirdShotY > yMin) && (thirdShotY < yMax) && (thirdShotX == xMax)) || ((thirdShotX > xMin) && (thirdShotX < xMax) && (thirdShotY == yMin)) || (thirdShotY > yMin) && (thirdShotY < yMax) && (thirdShotX == xMin))
        {
            sum += 50;
        }
        else if (((thirdShotX == xMin) && (thirdShotY == yMax)) || ((thirdShotX == xMax) && (thirdShotY == yMax)) || ((thirdShotX == xMax) && (thirdShotY == yMin)) || ((thirdShotX == xMin) && (thirdShotY == yMin)))
        {
            sum += 25;
        }
        else
        {
            sum += 0;
        }

        Console.WriteLine(sum+"%");

    }
}
