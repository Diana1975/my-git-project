using System;
using System.Collections.Generic;
using System.Text;

namespace Bankomatas
{
    class Saskaita
    {
        public string Vardas;
        public string Pavarde;
        public string SaskaitosNumeris;
        public decimal SaskaitosLikutis;


        public void SaskaitosInfo()
        {
            Console.WriteLine($"{Vardas}, {Pavarde},\nSaskaitos numeris: {SaskaitosNumeris},\nSaskaitos Likutis: {2000,00} eur");
        }

        List<Tranzakcija> Tranzakcijos = new List<Tranzakcija>();
        private object tranzakcija;

        public void Is(Tranzakcija tranzakcija)
        {
            if (tranzakcija.MokejimoSuma > SaskaitosLikutis)
            {
                Console.WriteLine($"Nepakanka lesu saskaitoje:");
            }
            else
            {
                Tranzakcijos.Add(tranzakcija);
                SaskaitosLikutis = SaskaitosLikutis - tranzakcija.MokejimoSuma;
            }

        }


        public void InestiPinigus(Tranzakcija tranzakcija)
        {
            Tranzakcijos.Add(tranzakcija);
            SaskaitosLikutis = SaskaitosLikutis + tranzakcija.MokejimoSuma;
        }


        public void AtspausdintiIsrasa()
        {
            Console.WriteLine($"Saskaitos israsas:");
            foreach (var tranzakcija in Tranzakcijos)
            {
                tranzakcija.TranzakcijosInformacija();

            }
            Console.WriteLine($"Saskaitos likutis: {SaskaitosLikutis}");
        }


        internal void AtliktiMokejima(Tranzakcija tranzakcija9)
        {
            if (tranzakcija.MokejimoSuma > SaskaitosLikutis)
            {
                Console.WriteLine($"Nepakanka lesu saskaitoje:");
            }
            else
            {
                Tranzakcijos.Add(tranzakcija);
                SaskaitosLikutis = SaskaitosLikutis - tranzakcija.MokejimoSuma;
            }
        }
    }
}
