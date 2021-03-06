﻿using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MyProtein.Tools
{
    public static class ManoScreenai
    {
        public static void MakePhoto(IWebDriver webdriver)
        {
            
            Screenshot manoScreenai = webdriver.TakeScreenshot();

            string screenShotDirectory =
                Path.GetDirectoryName(
                    Path.GetDirectoryName(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)));

            string sceenShotFolder = Path.Combine(screenShotDirectory, "screenshots");

            Directory.CreateDirectory(sceenShotFolder);

            string screenShotName = $"{TestContext.CurrentContext.Test.Name}_{DateTime.Now:HH-mm}.png";

            string screenshotPath = Path.Combine(sceenShotFolder, screenShotName);

            manoScreenai.SaveAsFile(screenshotPath, ScreenshotImageFormat.Png);

            Console.WriteLine($"Isssaugojom {screenshotPath}");
        }
    }
}
