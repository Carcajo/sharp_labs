using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4sharp
{
    class tarif
    {
        private int priceOfTarif;
        private int numberOfTarifClient;
        public tarif() { }

        private tarif(int priceOfTarif)
        {
            this.priceOfTarif = priceOfTarif;
        }
        private tarif(int priceTicket, int numberOfTicketsSold)
        {
            this.priceOfTarif = priceTicket;
            this.numberOfTarifClient = numberOfTicketsSold;
        }

        public void SetnumberOfTicketsSold()
        {
            while (!int.TryParse(Console.ReadLine(), out numberOfTarifClient) ||
                numberOfTarifClient > int.MaxValue || numberOfTarifClient < 0) Console.WriteLine("Введите корректное значение");
        }
        public void SetPriceTicket()
        {
            while (!int.TryParse(Console.ReadLine(), out priceOfTarif) ||
                priceOfTarif > int.MaxValue || priceOfTarif < 0) Console.WriteLine("Введите корректное значение");
        }
        public string TotalCostAllTickets()
        {
            return (priceOfTarif * numberOfTarifClient).ToString();
        }
        public void UpPrice()
        {
            int buf;
            while (!int.TryParse(Console.ReadLine(), out buf) ||
                buf > int.MaxValue || buf < 0) Console.WriteLine("Введите корректное значение");
            priceOfTarif += buf;
        }
        public void DownPrice()
        {
            int buf;
            while (!int.TryParse(Console.ReadLine(), out buf) ||
                buf > priceOfTarif || buf < 0) Console.WriteLine("Введите корректное значение");
            priceOfTarif -= buf;
        }
        public int PriceTarif
        {
            get { return priceOfTarif; }
        }
        public int NumberOfTarifsSold
        {
            get { return numberOfTarifClient; }
        }
    }
}
