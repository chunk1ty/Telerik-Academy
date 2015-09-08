namespace Structure3DPoint
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    public class Path
    {
        private List<Point3D> points = new List<Point3D>();
       
        public void AddPoint(Point3D point)
        {
            this.points.Add(point);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Point3D point in this.points)
            {
                sb.AppendFormat("X={0} Y={1} Z={2}", point.X, point.Y, point.Z);
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
}
