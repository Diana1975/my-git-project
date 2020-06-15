using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProtein.Tests
{
    class ProductsOfferTest : TestBase
    {
        [Test]

        public static void ProductsOfferTestas()
        {
            _productsOfferPage
                .GotoPage()
                .PasirinktiProduktuKategorija("Amino")
                .AssertPasirinktuProduktuKategorija()
                .PasirinktiMitybosProduktoTipa("Milteliai")
                .PasirinktiKieki("0,5kg – 1kg")
                .PatikrintiRezultatuKieki(6);
        }

    }

}

