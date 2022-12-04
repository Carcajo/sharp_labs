using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_TASK2
{
    class Class1
    {
        public int z;
        public int b;

        public Class1( int z, int b)
        {
            this.z = z;
            this.b = b;
        }
        public double schet()
        {
            double x;
            if (z <= 0)
               x = Math.Pow(z, b) + Math.Abs(b / 2);
            else
                x = Math.Sqrt(z);
            return ( 1 / Math.Cos(x) + Math.Log((Math.Abs(Math.Tan(x / 2))), Math.E));
        }
    }
}
