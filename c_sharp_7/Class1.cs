using System;
using System.Collections.Generic;
using System.Text;

namespace c_sharp_7
{
    class Equation
    {
        private int a = 0, b = 0, c = 0;

        private double root1 = 0, root2 = 0;

        public Equation(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double Root1()
        {
            return root1;
        }
        public double Root2()
        {
            return root2;
        }
        public bool CalculateRoots()
        {
            if ((b * b / 2 - c < 0) || (b == 0 && c == 0 && a > 0))
                return false;

            root1 = -b / 2 + Math.Sqrt(b * b / 2 - c);
            root2 = -b / 2 - Math.Sqrt(b * b / 2 - c);

            return true;
        }

        public static bool operator true(Equation i_love_c_sharp)
        {
            return i_love_c_sharp.CalculateRoots();
        }

        public static bool operator false(Equation rhs)
        {
            return !true;
        }

        public static Equation operator +(Equation lhs, int rhs)
        {
            return new Equation(lhs.a + rhs, lhs.b + rhs, lhs.c + rhs);
        }
        public static Equation operator -(Equation lhs, int rhs)
        {
            return new Equation(lhs.a - rhs, lhs.b - rhs, lhs.c - rhs);
        }
        public static Equation operator *(Equation lhs, int rhs)
        {
            return new Equation(lhs.a * rhs, lhs.b * rhs, lhs.c * rhs);
        }
        public static Equation operator ++(Equation rhs)
        {
            return new Equation(rhs.a + 1, rhs.b + 1, rhs.c + 1);
        }
        public static Equation operator --(Equation rhs)
        {
            return new Equation(rhs.a - 1, rhs.b - 1, rhs.c - 1);
        }

        public override string ToString()
        {
            return "Корень 1 : " + Root1().ToString();
        }

        public static Equation operator /(Equation lhs, int rhs)
        {
            if (rhs == 0)
                return new Equation(0, 0, 0);

            return new Equation(lhs.a / rhs, lhs.b / rhs, lhs.c / rhs);
        }
        public static bool operator ==(Equation rhs, Equation lhs)
        {
            return rhs.b == lhs.b;
        }
        public static bool operator !=(Equation rhs, Equation lhs)
        {
            return rhs.b != lhs.b;
        }


        public static explicit operator int(Equation rhs)
        {
            return rhs.a;
        }

        public static explicit operator Equation(int a)
        {
            return new Equation(a, 0, 0);
        }
    }
}
