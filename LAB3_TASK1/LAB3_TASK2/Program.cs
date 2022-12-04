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
            int z = Convert.ToInt32(Console.ReadLine());
            CLASS1 obj = new CLASS1(z);
            obj.schet();
            Console.WriteLine(obj.y);


        }
    }
    
}
