using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class SquareAndRektangle
    {
        private float basee;
        private float height;

        public SquareAndRektangle(float basee,float height)
        {
            this.basee = basee;
            this.height = height;
        }
        public float GetAreaSquare()
        {
            return basee * height;
        }
        public float GetSicumfrenceSquare()
        {
            return basee + height;
        }

    }
}
