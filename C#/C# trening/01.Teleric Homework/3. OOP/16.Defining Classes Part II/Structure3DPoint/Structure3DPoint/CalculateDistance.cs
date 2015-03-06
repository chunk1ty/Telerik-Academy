namespace Structure3DPoint
{
    using System;
    static class CalculateDistance
    {
        //d(p, q) = sqrt{(p_1 - q_1)^2 + (p_2 - q_2)^2+(p_3 - q_3)^2}.
        public static double Distance(Point3D first, Point3D second)
        {
            int differenceX = (int)Math.Pow((first.X - second.X), 2);
            int differenceY = (int)Math.Pow((first.Y - second.Y), 2);
            int differenceZ = (int)Math.Pow((first.Z - second.Z), 2);

            double result = Math.Sqrt(differenceX + differenceY + differenceZ);
            return result;
        }
    }
}
