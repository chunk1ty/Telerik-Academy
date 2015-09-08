using GeometryAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyGeometry
{
    public class Cylinder : Figure, IAreaMeasurable, IVolumeMeasurable
    {
        private Vector3D bottom;
        private Vector3D top;
        private double radius;

        public Cylinder(Vector3D bottom, Vector3D top, double radius)
        {            
            this.bottom = bottom;
            this.top = top;
            this.radius = radius;
        }
        
        public override double GetPrimaryMeasure()
        {
            throw new NotImplementedException();
        }

        public double GetArea()
        {
            throw new NotImplementedException();
        }

        public double GetVolume()
        {
            throw new NotImplementedException();
        }
    }
}
