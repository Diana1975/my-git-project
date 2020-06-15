using NUnit.Framework;
using NUnit.Framework.Internal.Execution;
using OpenQA.Selenium;
using OpenQA.Selenium.Internal;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProtein.Pages
{
    public class LogInSetupPage: BasePage
    {
        private static IWebElement ElektroninioPastoAdresas => Driver.FindElement(By.Id("username"));
        private static IWebElement Slaptazodis => Driver.FindElement(By.Id("password"));
        private static IWebElement Prisijungti => Driver.FindElement(By.Id("login-submit"));
        private static IWebElement Pasisveikinimas=> Driver.FindElement(By.ClassName("myAccountSection_header_welcome"));
        private static IWebElement Atsijungti => Driver.FindElement(By.CssSelector(".myAccount_logOutButton"));
        private static IWebElement PaskyrosMygtukas => Driver.FindElement(By.ClassName("responsiveAccountHeader_openAccountPanelText"));

        public LogInSetupPage(IWebDriver webdriver) : base(webdriver)
        {
        }


        public LogInSetupPage InsertEmailAddress(string emailAdress)
        {
            ElektroninioPastoAdresas.Click();
            ElektroninioPastoAdresas.Clear();
            ElektroninioPastoAdresas.SendKeys(emailAdress);

            return this;
        }
        public LogInSetupPage InsertPasword(string password)
        {
            Slaptazodis.Click();
            Slaptazodis.Clear();
            Slaptazodis.SendKeys(password);

            return this;
        }
        public LogInSetupPage PressPrisijungtiButton()
        {
            Prisijungti.Click();
            return this;
        }

        public LogInSetupPage AssertLoggedIn()
        {
            PaskyrosMygtukas.Click();
            var loggedprofileName = Pasisveikinimas.Text;
            Assert.True(loggedprofileName.Contains("Sveiki Atvykę Diana"), "Neprisijungus");
            return this;

        }
        public LogInPage LogOut()
        {
            Atsijungti.Click();

            return new LogInPage(Driver);
        }

    }


}

