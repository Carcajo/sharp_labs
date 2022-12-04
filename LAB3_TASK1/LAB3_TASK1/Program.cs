using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_TASK1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());
            CLASS obj = new CLASS(num);
            obj.smena();
            Console.WriteLine(obj.number);
        }
    }
}
