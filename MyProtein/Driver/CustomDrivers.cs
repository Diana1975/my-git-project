using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProtein.Driver
{
    public static class CustomDrivers
    {

        public static IWebDriver GetFireFoxDriver()
        {
            return GetDriver(Browser.FireFox);
        }

        public static IWebDriver GetFireFoxWithOptions()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.AddArgument("start-maximized");
            options.AddArgument("incognito");

            return new FirefoxDriver(options);
        }
        public static IWebDriver GetChromeDriver()
        {
            return GetDriver(Browser.Chrome);
        }

        public static IWebDriver GetChromeWithOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            options.AddArgument("incognito");

            return new ChromeDriver(options);
        }


        private static IWebDriver GetDriver(Browser browserName)
        {
            IWebDriver webDriver = null;

            switch (browserName)
            {
                case Browser.FireFox:
                    webDriver = GetFireFoxWithOptions();
                    break;
                case Browser.Chrome:
                    webDriver = GetChromeWithOptions();
                    break;
            }


            webDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            return webDriver;
        }

       

        
    }

}

