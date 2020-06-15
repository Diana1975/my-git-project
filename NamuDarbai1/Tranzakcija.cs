using System;
using System.Collections.Generic;
using System.Text;

namespace NamuDarbai1
{
    public enum ValiutosTipas { EUR, SEK, LTL, GBP}
    class Tranzakcija
    {
        public decimal MokejimoSuma;
        public string MokejimoPaskirtis;
        public DateTime Laikas = DateTime.Now;
        public ValiutosTipas Valiuta;
        

        public void TranzakcijosInformacija()
        {

            Console.WriteLine($"{MokejimoSuma},{MokejimoPaskirtis},{Laikas},{Valiuta}");
        }
    }

}
