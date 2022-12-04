using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_TASK2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите z:");
            int z = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите k:");
            int k = Convert.ToInt32(Console.ReadLine());

            Class1 obj = new Class1(z, k);

            double y = obj.Counter();

            Console.WriteLine(y);
            if (k < 1)
                Console.WriteLine("Ветка №1:");
            else 
                Console.WriteLine("Ветка №2:");
        }
    }
}
