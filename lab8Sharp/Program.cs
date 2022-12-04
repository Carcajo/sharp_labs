using System;

namespace Lab8Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Airport Domodedovo = Airport.CreateAirport("name");

            Tariff tariff = new Tariff("Moscow", "London", "250");

            SpecialTariff spc_tar = new SpecialTariff("Paris", "Vitebsk", "440", "30");

            Domodedovo.Add(tariff);

            Domodedovo.Add(spc_tar);

            Domodedovo.Show(); Domodedovo.ShowSpecial();
        }
    }
}
