using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProtein.Pages
{
    public class HomePage : BasePage
    {

        //elementai
        private static IWebElement PaieskosLaukas => Driver.FindElement(By.ClassName("headerSearch_input")); 
        private static IWebElement PaieskosMygtukas => Driver.FindElement(By.CssSelector(".headerSearch_button > .headerSearch_spyglass"));
        private static IWebElement AtsakymoLaukas => Driver.FindElement(By.ClassName("responsiveProductListHeader_title"));
        private static IWebElement NeigiamoAtsakymoLaukas => Driver.FindElement(By.CssSelector("#responsive-product-list-title")); 

        //konstruktorius
        public HomePage(IWebDriver webdriver) : base(webdriver)
        {
        }

        public HomePage GotoPage()
        {
            Driver.Url = "https://www.myprotein.lt/elysium.search?";
            return this;
        }

        public HomePage KlikSearchLine()
        {
            PaieskosLaukas.Click();
            return this;
        }
         
        public HomePage InsertSearchText(string text)
        {
            PaieskosLaukas.Clear();
            PaieskosLaukas.SendKeys(text);
            return this;
        }
        public HomePage KlikSearchButton()
        {
            PaieskosMygtukas.Click();
            return this;
        }
        public HomePage AssertSearchMessage(string text)
        {
            Assert.AreEqual($"“{text}”", AtsakymoLaukas.Text, "Nesutampa paieskos rezultatai");
            return this;
        }
        public HomePage InsertWrongSearchText(int a)
        { 
            PaieskosLaukas.Clear();
            PaieskosLaukas.SendKeys(a.ToString());
            PaieskosLaukas.Click();

            return this;
        }
        public HomePage AsserSerchMessage(int a)
        {
            Assert.AreNotEqual(a.ToString(),NeigiamoAtsakymoLaukas.Text, "Atsiprašome, tačiau neradome jokių rezultatų, kuriuose būtų''");
            return this;

        }
    }
}
