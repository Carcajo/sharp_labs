using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8Sharp
{
    public interface ITariff
    {
        public void ShowTariff();
        public int Price();
    }

    public class Tariff : ITariff
    {
        private string dist, source, price;

        public Tariff(string dist_, string source_, string price_)
        {
            dist = dist_;
            source = source_;
            price = price_;
        }

        void ITariff.ShowTariff()
        {
            Console.WriteLine($"{dist} - {source} - {price}$");
        }

        int ITariff.Price()
        {
            return Int32.Parse(price);
        }
    }

    public class SpecialTariff : ITariff
    {
        private string discount, dist, source, price;

        public SpecialTariff(string dist_, string source_, string price_, string discount_)
        {
            dist = dist_;
            source = source_;
            price = price_;
            discount = discount_;
        }
        void ITariff.ShowTariff()
        {
            Console.WriteLine($"{dist} - {source} - {price}$ - {discount}%");
        }
        int ITariff.Price()
        {
            return Int32.Parse(price) -
                (Int32.Parse(price) * Int32.Parse(discount) / 100);
        }
    }
    public class Airport
    {
        private static Airport airport;

        private string name = "";

        List<Tariff> tariffs = new List<Tariff>();
        List<SpecialTariff> sp_tariffs = new List<SpecialTariff>();

        private ITariff? tariff;
        private ITariff? MaxPrice;

        Airport(string name_)
        {
            name = name_;
        }

        public static Airport CreateAirport(string name_)
        {
            if (airport == null)
                airport = new Airport(name_);

            return airport;
        }

        public int MaxTariff()
        {
            int max = 0;

            foreach (var current in tariffs)
            {
                MaxPrice = current;
                if (max < MaxPrice.Price())
                    max = MaxPrice.Price();
            }

            foreach (var current in sp_tariffs)
            {
                MaxPrice = current;
                if (max < MaxPrice.Price())
                    max = MaxPrice.Price();
            }

            return max;
        }

        public void Add(Tariff tariff)
        {
            tariffs.Add(tariff);
        }
        public void Add(SpecialTariff sp_tariff)
        {
            sp_tariffs.Add(sp_tariff);
        }
        public void Show()
        {
            foreach (var cur in tariffs)
            {
                tariff = cur;
                tariff.ShowTariff();
            }

        }
        public void ShowSpecial()
        {
            foreach (var cur in sp_tariffs)
            {
                tariff = cur;
                tariff.ShowTariff();
            }
        }
    }
}
