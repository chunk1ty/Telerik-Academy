namespace Structure3DPoint
{
    using System;
    public struct Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Point3D(int x,int y,int z):this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        private static readonly Point3D startPoint = new Point3D(0, 0, 0);
        public static Point3D StartPoint
        {
            get
            {
                return startPoint;
            }
        }
        public override string ToString() 
        {
            string result = string.Format("X=" + this.X + " Y=" + this.Y + " Z=" + this.Z);
            return result;
        }
    }
}
