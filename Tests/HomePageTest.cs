using MyProtein.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProtein.Tests
{
    public class HomePageTest : TestBase
    {
       
        [TestCase("Omega")]
        [TestCase("Vitaminai")]
        [TestCase("Baltymai")]
       
        public static void PaieskosLaukoTestas(string text)
        {
            _homePage
                .GotoPage()
                .KlikSearchLine()
                 .InsertSearchText(text)
                 .KlikSearchButton()
                 .AssertSearchMessage(text);
        }

        [TestCase(1234)]
        public static void PaieskosLaukoTestasNAN(int a)
        {
            _homePage
                .GotoPage()
                .KlikSearchLine()
                .InsertWrongSearchText(a)
                .AsserSerchMessage(a);
        }
    }

}
