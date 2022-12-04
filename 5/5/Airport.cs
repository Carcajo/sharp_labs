using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Airport
    {
        List<Fare> fare = new List<Fare>();
        public void AddPassenger()
        {
            fare.Add(new Fare());
        }
        public void SetPassportData(string passportData)
        {
            fare[fare.Count - 1].passport.passportData = passportData;
        }
        public void SetNumberOfTickets(int numberOfTickets)
        {
            fare[fare.Count - 1].passport.numberOfTickets = numberOfTickets;
        }
        public void SetPriceTicket(string passportData, int numberOfTickets, FareType FType)
        {
            fare[fare.Count - 1].SetPriceTicket(passportData, numberOfTickets, FType);
        }
        public string PassportData
        {
            get
            { return fare[fare.Count - 1].passport.passportData; }
        }

        public int NumberOfTickets
        {
            get
            { return fare[fare.Count - 1].passport.numberOfTickets; }
        }
        public int PriceTicket
        {
            get
            { return fare[fare.Count - 1].priceTicket; }
        }

        public void update()
        {
            for (int a=0; a < fare.Count; a++)
            {
                fare[a].updatePrice();
            }
        }

        public string Print(string buffer = "")
        {
            double buf=0;
            for (int a = 0; a < fare.Count; a++)
            {
                buf += fare[a].priceTicket;
                buffer += "\nПаспортные данные: " + fare[a].passport.passportData +
                    "\nCтоимость купленных пассажиром билетов: " + fare[a].priceTicket.ToString();
                switch ((int)fare[a].FType)
                {
                    case 0: buffer += "\nТариф: Light\n"; break;
                    case 1: buffer += "\nТариф: Smart\n"; break;
                    case 2: buffer += "\nТариф: Business\n"; break;
                }
            }
            buffer += "\n\nCтоимость всех проданных билетов: " + buf.ToString();
            return buffer;
        }
    }
}
