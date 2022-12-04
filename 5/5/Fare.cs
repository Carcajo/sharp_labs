using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    enum FareType { light, smart, business };
    class Fare
    {
        public int priceTicket;
        private static int[] priceFareType = new int[3];
        public Passenger passport = new Passenger();
        public FareType FType;
        public Fare() { }
        public void FarePrice(int light, int smart, int business)
        {
            priceFareType[0] = light;
            priceFareType[1] = smart;
            priceFareType[2] = business;
        }
        public void SetPriceTicket(string passportData, int numberOfTickets, FareType FType)
        {
            this.FType = FType;
            passport.SetPassenger(passportData, numberOfTickets);
            priceTicket = passport.numberOfTickets * priceFareType[(int)FType];
        }
        public void updatePrice()
        {
            priceTicket = passport.numberOfTickets * priceFareType[(int)FType];
        }

    }
}
