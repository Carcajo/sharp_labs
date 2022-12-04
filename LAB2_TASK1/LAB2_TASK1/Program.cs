using System;

namespace LAB2_TASK1
{
    class Program
    {
        static void Main()
        {

            bool z = true;
            while (z)
            {
                Console.Write("Введите число: ");
                int num = Convert.ToInt32(Console.ReadLine());
                int a = num % 10;
                int b = num / 10;
                if ((a + b) % 2 == 0)
                    Console.Write("Сумма цифр четна \n");
                else
                    Console.Write("Сумма цифр нечетна \n");
               
                Console.Write("Нажмите 1, если хотите продолжить\nНажмите 2, если хотите закончить\n ");
                int q = Convert.ToInt32(Console.ReadLine());
                if (q == 2)
                    z = false;
            }
        }
        }
    }

