using System;

class SurfaceOfTriangle
{
    static void Main()
    {
       
    }

    static int FindSurfaceBySideAndAltitude(int a,int hA)
    {
        int surface = a * hA;
        return surface;
    }

    static double FindSurfaceByThreeSides(int a,int b,int c)
    {
        double p = (a + b + c) / 2.0;
        double surface = Math.Sqrt (p * (p - a) * (p - b) * (p - c));
        return surface;
    }

    // S = ½ab sin γ
    static double FindSurfaceByTwoSidesAndAngle(int a,int b , int sinA)
    {
        //                          rad--> degree
        double sinAngle = Math.Sin(Math.PI * sinA / 180);
        double surface = a * b * sinAngle / 2;
        return surface;
    }
}

