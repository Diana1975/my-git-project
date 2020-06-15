using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProtein.Pages
{
    public class BasketSetupPage : BasePage
    {
        //private static IWebElement Pirkinys => Driver.FindElement(By.CssSelector(".athenaBasket_basketItemRow"));
        private static IWebElement PirkinioPavadinimas => Driver.FindElement(By.ClassName("athenaBasket_itemName"));
        private static IWebElement PirkinioKaina => Driver.FindElement(By.CssSelector("div.athenaBasket_bodyItem:nth-child(4)"));
        private static IWebElement PirkinioNuolaida => Driver.FindElement(By.CssSelector(".athenaBasket_totalSavingsHeader"));
        private static IWebElement UzsisakytiSaugiaiDabar => Driver.FindElement(By.CssSelector(".athenaBasket_basketButtons_flexItem-checkoutSecurely > form:nth-child(1) > button:nth-child(1)"));
        private static IWebElement NuolaidosLangas => Driver.FindElement(By.Id("discountcode"));
        private static IWebElement NaudotiKodaMygtukas => Driver.FindElement(By.Id("add-discount-code")); 

        public BasketSetupPage (IWebDriver webdriver) : base(webdriver)
        {
        }

        public BasketSetupPage PatikrinamPrekesPavadinima(string pavadinimas)
        {
            Assert.True(PirkinioPavadinimas.Text.Contains(pavadinimas), "Ne ta preke");
            return this;
        }
        public BasketSetupPage PatikrinamPrekesKaina (string kaina)
        {
            Assert.True(PirkinioKaina.Text.Contains(kaina), "Ne ta kaina");
            return this;
        }
        public BasketSetupPage UzpildomeNuolaidosLanga(string kodas)
        {
           NuolaidosLangas.Click();
           NuolaidosLangas.SendKeys(kodas);
            NaudotiKodaMygtukas.Click();
           return this;
        }

        public BasketSetupPage PatikrinamPrekesNuolaida(string nuolaida)
        {
            Assert.True(PirkinioNuolaida.Text.Contains(nuolaida), "Nepaskaiciavo nuolaidos");
            return this;
        }

        public LogInSetupPage UzsisakytiPreke()
        {
            UzsisakytiSaugiaiDabar.Click();
            return new LogInSetupPage (Driver);
        }
    }
}  
