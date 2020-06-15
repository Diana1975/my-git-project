using System;

namespace Bankomatas
{
    internal class Tranzakcija
    {
        public string MokejimoPaskirtis { get; internal set; }
        public decimal MokejimoSuma { get; internal set; }
        public string Valiuta { get; internal set; }

        internal void TranzakcijosInformacija()
        {
            throw new NotImplementedException();
        }
    }
}