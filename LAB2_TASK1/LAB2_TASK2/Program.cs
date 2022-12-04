using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB2_TASK2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите x");
            var x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите y");
            var y = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(x) >= y && x * x + y * y <= 25 * 25)
            {
                if (Math.Abs(x) == y || x * x + y * y == 25 * 25)
                {
                    Console.WriteLine("На границе");
                }
                else
                {
                    Console.WriteLine("Да");
                }
            }
            else
            {
                Console.WriteLine("Нет");
            }

        }
    }
}
