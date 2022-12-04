using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_TASK2
{
    class Class1
    {
        public double y;
        double x;
        int z;
        int b;

        public Class1(int x, int z, int b, int y)
        {
            this.y = y;
            this.x = x;
            this.z = z;
            this.b = b;
        }
        public void schet()
        {
            if (z <= 0)
                x = Math.Pow(z, b) + Math.Abs(b / 2);
            else
                x = Math.Sqrt(z);
            y = 1 / Math.Cos(x) + Math.Log((Math.Abs(Math.Tan(x / 2))), Math.E);
        }
    }
}
