using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3_TASK3
{
    public class MyClass
    {
        public static void GetDay(string date)
        {
            char[] arrays = date.ToCharArray();

            var data = date.Split(new char[] { '.', ',', '/' });

            int day, month, year;

            day = (arrays[0] - 48) * 10 + arrays[1] - 48;
            month = (arrays[3] - 48) * 10 + arrays[4] - 48;
            year = (arrays[6] - 48) * 1000 + (arrays[7] - 48) * 100 + (arrays[8] - 48) * 10 + (arrays[9] - 48);

            DateTime date1 = new DateTime(year, month, day);
            Console.WriteLine("\nДень недели: " + date1.ToString("dddd") + "\n");
        }
        public static void GetDaysSpan(int day, int month, int year)
        {
            int day_, month_, year_;

            string x = Convert.ToString(System.DateTime.Now);

            char[] arrays = x.ToCharArray();

            day_ = (arrays[0] - 48) * 10 + arrays[1] - 48;
            month_ = (arrays[3] - 48) * 10 + arrays[4] - 48;
            year_ = (arrays[6] - 48) * 1000 + (arrays[7] - 48) * 100 + (arrays[8] - 48) * 10 + (arrays[9] - 48);

            DateTime date1 = new DateTime(year, month, day);
            DateTime date2 = new DateTime(year_, month_, day_);
            Console.WriteLine("\n\nРазность дней между настоящим и введённым временем: " + date1.Subtract(date2).Days);
        }
    }
}
