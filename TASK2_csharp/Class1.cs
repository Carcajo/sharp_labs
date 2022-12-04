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
        public int k;

        public Class1(int z, int k)
        {
            this.z = z;
            this.k = k;
        }
        public double Counter()
        {
            double x;
            if (k < 1)
                x = Math.Pow(z, 3) *k;
            else
                x = z*(z+1);
            return Math.Pow(Math.Log(1 + Math.Pow(x, 2)) + Math.Cos(x + 1), Math.Pow(Math.E, k * x));
        }
    }
}
