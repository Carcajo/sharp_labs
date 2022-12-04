using System;

namespace c_sharp_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Equation Example = new Equation(1, 2, -5);


            double FirstRoot = 0, SecondRoot = 0;

            if (Example.CalculateRoots())
            {
                FirstRoot = Example.Root1();
                SecondRoot = Example.Root2();
            }
            int x = (int)Example;

            int y = 7;
            Equation NewExample = (Equation)y;
            Console.WriteLine(NewExample);
        }
    }
}
