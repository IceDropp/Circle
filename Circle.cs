using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Circle
    {
        private float radius;
        public Circle(float radius)
        {  
            this.radius = radius; 
        }
        public float GetArea()
        {
            return MathF.PI * radius * radius;
        }
        public float GetSphereVolume()
        {
            return MathF.PI * radius * radius * radius * 4 / 3;
        }
    }
}
