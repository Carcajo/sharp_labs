using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB3_TASK3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите дату например (02.03.2022) для того чтобы узнать день недели");

            string date = Console.ReadLine();
            MyClass.GetDay(date);

            Console.Write("Введите число дня: ");
            int day = Convert.ToInt32(Console.ReadLine());

            Console.Write('\n');

            Console.Write("Введите число месяца: ");
            int month = Convert.ToInt32(Console.ReadLine());

            Console.Write('\n');

            Console.Write("Введите год: ");
            int year = Convert.ToInt32(Console.ReadLine());

            MyClass.GetDaysSpan(day, month, year);
        }
    }
}