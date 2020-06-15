using MyProtein.Driver;
using MyProtein.Pages;
using MyProtein.Tools;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MyProtein.Tests
{
    public class TestBase
    {
        public static IWebDriver _driver;

        public static HomePage _homePage;
        public static LogInPage _logInPage;
        public static ProductsOfferPage _productsOfferPage;
        public static BasketPage _basketPage;
        


        [OneTimeSetUp]
        public static void SetUpFireFox()
        {
            _driver = CustomDrivers.GetFireFoxWithOptions();

            _homePage = new HomePage(_driver);
            _logInPage = new LogInPage(_driver);
            _productsOfferPage = new ProductsOfferPage(_driver);
            _basketPage = new BasketPage(_driver);
           
        }

        [TearDown]
        public static void SingleTestTearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                ManoScreenai.MakePhoto(_driver);
            }
        }

        [OneTimeTearDown]
        public static void CloseBrowser()
        {
            _driver.Quit();
        }
       
    }

    
}

