using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProtein.Pages
{
    public class ProductsOfferPage : BasePage
    {
        private IWebElement Produktas => Driver.FindElement(By.CssSelector("div.responsiveFacets_sectionContainer:nth-child(2) > div:nth-child(2) > fieldset:nth-child(1) > label:nth-child(3) > span:nth-child(2)"));
        private IWebElement PasirinktaProduktoKategorija => Driver.FindElement(By.ClassName("responsiveFacets_selectionValue"));
        private IWebElement PasirinktaMitybosProduktoTipas => Driver.FindElement(By.CssSelector(".responsiveFacets_sectionContainer:nth-child(4) .responsiveFacets_sectionItemLabel:nth-child(2) .responsiveFacets_sectionItemValue")); 
        private IWebElement PasirinktaKiekis => Driver.FindElement(By.CssSelector(".responsiveFacets_sectionContainer:nth-child(6) .responsiveFacets_sectionItemLabel:nth-child(2) .responsiveFacets_sectionItemValue"));
        private int RezultatuLaukas=> Convert.ToInt32(Driver.FindElement(By.CssSelector(".responsiveProductListHeader_resultsCount")).Text.Replace("results",""));
        
                   
        public ProductsOfferPage(IWebDriver webdriver) : base(webdriver)
        {
        }
        public ProductsOfferPage GotoPage()
        {
            Driver.Url = "https://www.myprotein.lt/all-offers/50-off.list";
            return this;
        }
        public ProductsOfferPage PasirinktiProduktuKategorija(string produktas)
        {
            if (Produktas.Text.Contains(produktas))
            {
                Produktas.Click();
            }
            return this;
        }
        public ProductsOfferPage PasirinktiMitybosProduktoTipa(string tipas)
        {
            if (PasirinktaMitybosProduktoTipas.Text.Contains(tipas))
            {
                PasirinktaMitybosProduktoTipas.Click();
            }
            return this;
        }
        public ProductsOfferPage PasirinktiKieki(string kiekis)
        {
            if (PasirinktaKiekis.Text.Contains(kiekis))
            {
                PasirinktaKiekis.Click();
            }
            return this;
        }
        public ProductsOfferPage  AssertPasirinktuProduktuKategorija()
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(5));
            Assert.True(Produktas.Text.Contains(PasirinktaProduktoKategorija.Text), "Nepavyko");
            return this;
        }
        public ProductsOfferPage PatikrintiRezultatuKieki(int expectedResultCount)
        {
              Assert.GreaterOrEqual(RezultatuLaukas, expectedResultCount, "Rezultatu didesnis mazesnis nei tikejomes");
            return this;
        }


    }
}
