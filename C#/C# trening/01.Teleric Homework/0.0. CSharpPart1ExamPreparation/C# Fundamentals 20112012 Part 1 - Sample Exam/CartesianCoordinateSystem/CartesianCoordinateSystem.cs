using System;


class CartesianCoordinateSystem
{
    static void Main()
    {

        double pointX = double.Parse(Console.ReadLine());
        double pointY = double.Parse(Console.ReadLine());
        int result=0;

        if (pointX==0 && pointY==0)
        {
            result = 0;
        }
        else if (pointX>0 && pointY>0)
        {
            result = 1;
        }
        else if (pointX < 0 && pointY > 0)
        {
            result = 2;
        }
        else if (pointX < 0 && pointY < 0)
        {
            result = 3;
        }
        else if (pointX > 0 && pointY < 0)
        {
            result = 4;
        }
        else if (pointX ==0)
        {
            result = 5;
        }
        else
        {
            result = 6;
        }
        Console.WriteLine(result);     
    }
}

