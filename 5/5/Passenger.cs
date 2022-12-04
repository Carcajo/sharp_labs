using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5
{
    class Passenger
    {
        public string passportData;
        public int numberOfTickets;
        public void SetPassenger(string passportData, int numberOfTickets)
        {
            this.passportData = passportData;
            this.numberOfTickets = numberOfTickets;
        }
    }
}
