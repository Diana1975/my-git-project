using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProtein.Pages
{
    public class LogInPage :BasePage
    {

        private static IWebElement PaskyrosMygtukas => Driver.FindElement(By.ClassName("responsiveAccountHeader_openAccountPanelText"));


        private static IWebElement PirktiDabarMygtukas => Driver.FindElement(By.XPath("/html/body/main/div[1]/div/a/picture/img"));  
        public LogInPage(IWebDriver webdriver) : base(webdriver)
        {
        }
        public LogInPage GotoPage()
        {
            Driver.Url = "https://www.myprotein.lt/";
            return this;
        }

        public LogInSetupPage MarkLogInButton()
        {
           PaskyrosMygtukas.Click();  //uzeiti su pele

            return new LogInSetupPage(Driver);
        }
       

    }
}
