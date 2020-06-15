using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace NamuDarbai1
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

        public void AtliktiMokejima(Tranzakcija tranzakcija)
        {
            if (tranzakcija.MokejimoSuma > SaskaitosLikutis)
            {
                Console.WriteLine($"Nepakanka lesu saskaitoje:");
            }
            else
            {
                Tranzakcijos.Add(tranzakcija);
                SaskaitosLikutis = SaskaitosLikutis - KonvertuotiIEurus(tranzakcija.MokejimoSuma, tranzakcija.Valiuta);
            }

        }


        public void GautinosIplaukos(Tranzakcija tranzakcija)
        {
            Tranzakcijos.Add(tranzakcija);
            SaskaitosLikutis = SaskaitosLikutis + KonvertuotiIEurus(tranzakcija.MokejimoSuma,tranzakcija.Valiuta);
        }

        public decimal KonvertuotiIEurus(decimal suma, ValiutosTipas valiuta)
        {
            decimal rezultatas = 0;
            switch (valiuta)
            {
                case ValiutosTipas.EUR:
                    rezultatas = suma * 1;
                        break;
                case ValiutosTipas.SEK:
                    rezultatas = suma / 10;
                    break;
                case ValiutosTipas.LTL:
                    rezultatas = suma / 3.4528M;
                    break;
                case ValiutosTipas.GBP:
                    rezultatas = suma / 5;
                    break;
                default:
                    break;
            }


            return rezultatas;
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

        public void pervestiPinigu()
        {
            Console.WriteLine("Ka norite atlikti: 1. - Sumoketi, 2. - Papildyti saskaita");
            string pasirinkimas = Console.ReadLine();
            Console.WriteLine("Iveskite suma:");
            decimal suma = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Iveskite valiuta:(1-EUR, 2-SEK, 3- LTL, 4-GBP");

            int valiutosPasirinkimas = Convert.ToInt32(Console.ReadLine());
            ValiutosTipas valiuta = (ValiutosTipas)valiutosPasirinkimas - 1;

            if (pasirinkimas == "1")
            {

            }
            else if (pasirinkimas == "2")
            {

            }
            else
            {
                Console.WriteLine("Blogas  pasirinkimas");
            }
        }

        


    }

}