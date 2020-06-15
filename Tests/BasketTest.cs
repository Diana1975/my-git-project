using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyProtein.Tests
{
    public class BasketTest : TestBase
    {
       
        [Test]
        public static void PirkiniuKrepselioTestas()
        {
            _basketPage
                 .GotoPage()
                 .PasirinktosPrekesPasirinkimas()
                 .PasirinktosPrekesIkelimasIPirkiniuKrepseli()
                 .TestiApsipirkima()
                 .Krepselis()
                 .PatikrinamPrekesPavadinima("Clear Vegan Protein")
                 .PatikrinamPrekesKaina("27.99€")
                 .UzpildomeNuolaidosLanga("30LT")
                 .PatikrinamPrekesNuolaida("8.40€")
                 .UzsisakytiPreke();

        }

    }
}
