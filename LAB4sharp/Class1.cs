using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB4sharp
{
    class Internet
    {
        private string Operator;
        private int numberOfClients;
        private tarif Tarif = new tarif();
        private static Internet Internets = null;

        private Internet() { }
        public void SetOperatorName()
        {
            Operator = Console.ReadLine();
        }
        public void SetNumberOfClients()
        {
            while (!int.TryParse(Console.ReadLine(), out numberOfClients) ||
                numberOfClients > int.MaxValue || numberOfClients < 0) Console.WriteLine("Введите корректное значение");
        }
        public void SetnumberOfTicketsSold()
        {
            Tarif.SetnumberOfTicketsSold();
        }
        public void SetPriceTarif()
        {
            Tarif.SetPriceTicket();
        }
        public string TotalCostAllTickets()
        {
            return Tarif.TotalCostAllTickets();
        }
        public void UpPrice()
        {
            Tarif.UpPrice();
        }
        public void DownPrice()
        {
            Tarif.DownPrice();
        }
        public string NameOperator
        {
            get { return Operator; }
        }
        public int NumberOfClients
        {
            get { return numberOfClients; }
        }
        public int NumberOfTarifsSold
        {
            get { return Tarif.NumberOfTarifsSold; }
        }
        public int PriceTarif
        {
            get { return Tarif.PriceTarif; }
        }
        public static Internet Initialize()
        {
            if (Internets == null) Internets = new Internet();
            return Internets;
        }
    }
}
