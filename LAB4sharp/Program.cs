
using System;

namespace LAB4sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 1;
            Internet internet = Internet.Initialize();
            while (true)
            {
                switch (n)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Введите название оператора: ");
                        internet.SetOperatorName();
                        Console.Clear();
                        Console.WriteLine("Введите стоимость тарифа: ");
                        internet.SetPriceTarif();
                        Console.Clear();
                        Console.WriteLine("Введите общее число клиентов: ");
                        internet.SetNumberOfClients();
                        Console.Clear();
                        Console.WriteLine("Введите число клиентов,которые приобрели тариф: ");
                        internet.SetnumberOfTicketsSold();
                        n = 5;
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Стоимость тарифа:" + internet.PriceTarif);
                        Console.WriteLine("\nВведите на сколько увеличить стоимость тарифа: ");
                        internet.UpPrice();
                        n = 5;
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Стоимость билета:" + internet.PriceTarif);
                        Console.WriteLine("\nВведите на сколько уменьшить стоимость тарифа: ");
                        internet.DownPrice();
                        n = 5;
                        break;
                    case 4:
                        return;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("Данные:\nНазвание оператора:" + internet.NameOperator +
                            "\nСтоимость тарифа:" + internet.PriceTarif +
                            "\nОбщее число клиентов:" + internet.NumberOfClients +
                            "\nЧисло клиентов, которые приобрели тариф:" + internet.NumberOfTarifsSold +
                            "\nОбщей стоимости выручки:" + internet.TotalCostAllTickets());
                        Console.WriteLine("\n\n1 - заново\n2 - увеличить стоимость тарифа\n3 - уменьшить стоимость тарифа\n4 - выйти");
                        while (!int.TryParse(Console.ReadLine(), out n) || n > 4 || n < 1) Console.WriteLine("Введите корректное значение");
                        break;
                }
            }
        }
    }
}
