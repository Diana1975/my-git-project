using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProtein.Pages
{
    public class BasketPage:BasePage
    {
        private static IWebElement GreitasApsipirkimasMygtukas => Driver.FindElement(By.CssSelector("li.productListProducts_product:nth-child(1) > div:nth-child(1) > div:nth-child(2) > div:nth-child(3) > a:nth-child(1)"));
        private static IWebElement DetiIKrepseliMygtukas => Driver.FindElement(By.CssSelector(".productAddToBasket"));
        private static IWebElement TestiApsipirkimaMygtukas => Driver.FindElement(By.CssSelector(".addedToBasket_continueShoppingButton"));
        private static IWebElement KrepselisMygtukas => Driver.FindElement(By.ClassName ("responsiveFlyoutBasket_name"));



        //konstruktorius
        public BasketPage (IWebDriver webdriver) : base(webdriver)
        {
        }

        public BasketPage GotoPage()
        {
            Driver.Url = "https://www.myprotein.lt/dietary-needs/vegan.list";
            return this;
        }
        public BasketPage PasirinktosPrekesPasirinkimas()
        {
            GreitasApsipirkimasMygtukas.Click();
            return this;
        }
        public BasketPage PasirinktosPrekesIkelimasIPirkiniuKrepseli()
        {
            DetiIKrepseliMygtukas.Click();
            return this;
        }
        public BasketPage TestiApsipirkima()
        {
            TestiApsipirkimaMygtukas.Click();
            return this;
        }
        public BasketSetupPage Krepselis()
        {
           KrepselisMygtukas.Click();
            return new BasketSetupPage(Driver);
        }
       



       





    }
}
