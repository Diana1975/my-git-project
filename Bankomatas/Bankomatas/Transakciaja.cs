using System;
using System.Collections.Generic;
using System.Text;

namespace Bankomatas
{
    class Transakciaja
    {

        public decimal MokejimoSuma;
        public string MokejimoPaskirtis;
        public DateTime Laikas = DateTime.Now;
        public string Valiuta;


        public void TranzakcijosInformacija()
        {

            Console.WriteLine($"{MokejimoSuma},{MokejimoPaskirtis},{Laikas},{Valiuta}");
        }
    }
}



