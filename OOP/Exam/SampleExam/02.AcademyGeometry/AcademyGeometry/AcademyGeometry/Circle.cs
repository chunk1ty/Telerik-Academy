using GeometryAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGeometry
{
    public class Circle : Figure, IAreaMeasurable, IFlat
    {
        private Vector3D a;
        private double radius;
        public Circle(Vector3D a, double b)
        {
            this.a = a;
            this.radius = b;
        }
        public override double GetPrimaryMeasure()
        {
            return this.GetArea();
        }

        public double GetArea()
        {
            return Math.PI * radius * radius;
        }

        public Vector3D GetNormal()
        {
            Vector3D result = new Vector3D(a.X, a.Y, 0);
            result.Normalize();

            return result;
        }
    }
}
