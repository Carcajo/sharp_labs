using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_TASK1
{
    class CLASS
    {
        public int number;
        public CLASS(int number)
        {
            this.number=number;
        }
        public void smena()
        {
            if (number < 100 && number >10)
                number = (number % 10) * 10 + number / 10;
        }

        
    }
}
