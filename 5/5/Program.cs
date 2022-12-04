using System;
using System.Collections.Generic;
namespace _5
{
    class Program
    {
        static void Main()
        {
            int Light,Smart, Business;
            int n=2,buf;
            Fare farePrice = new Fare();
            Airport airport = new Airport();
            while (true)
            {
                switch (n)
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine(airport.Print());
                        Console.WriteLine("\n\n1 - Добавить данные" +
                            "\n2 - Изменить тариф" +
                            "\n3 - Выйти");
                        while (!int.TryParse(Console.ReadLine(), out n) ||
                        n > 3 || n < 1) Console.WriteLine("Введите корректное значение");
                        break;
                    case 1:
                        Console.Clear();
                        airport.AddPassenger();
                        Console.WriteLine("Введите номер паспорта: ");
                        airport.SetPassportData(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("Количество билетов: ");
                        while (!int.TryParse(Console.ReadLine(), out buf) ||
                        buf > int.MaxValue || buf < 0) Console.WriteLine("Введите корректное значение");
                        airport.SetNumberOfTickets(buf);
                        Console.Clear();
                        Console.WriteLine("Тариф: " +
                            "\n1 - Light" +
                            "\n2 - Smart" +
                            "\n3 - Business");
                        while (!int.TryParse(Console.ReadLine(), out buf) ||
                        buf > 3 || buf < 1) Console.WriteLine("Введите корректное значение");
                        airport.SetPriceTicket(airport.PassportData, airport.NumberOfTickets, FareType.light);
                        switch (buf)
                        {
                            case 1: airport.SetPriceTicket(airport.PassportData, airport.NumberOfTickets, FareType.light); break;
                            case 2: airport.SetPriceTicket(airport.PassportData, airport.NumberOfTickets, FareType.smart); break;
                            case 3: airport.SetPriceTicket(airport.PassportData, airport.NumberOfTickets, FareType.business); break;
                        }
                        n = 0;
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Стоимость тарифа Light: ");
                        while (!int.TryParse(Console.ReadLine(), out Light) ||
                            Light > int.MaxValue || Light < 0) Console.WriteLine("Введите корректное значение");
                        Console.Clear();
                        Console.WriteLine("Стоимость тарифа Smart: ");
                        while (!int.TryParse(Console.ReadLine(), out Smart) ||
                            Smart > int.MaxValue || Smart < 0) Console.WriteLine("Введите корректное значение");
                        Console.Clear();
                        Console.WriteLine("Стоимость тарифа Business: ");
                        while (!int.TryParse(Console.ReadLine(), out Business) ||
                            Business > int.MaxValue || Business < 0) Console.WriteLine("Введите корректное значение");
                        farePrice.FarePrice(Light, Smart, Business);
                        airport.update();
                        n = 0;
                        break;
                    case 3: return;
                }
            }
        }
    }
}
