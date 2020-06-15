using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProtein.Tests
{
    class LogInTest : TestBase
    {
        [Test]

        public static void LogInTestas()
        {
            _logInPage
                .GotoPage()
                .MarkLogInButton()
                .InsertEmailAddress("diana.martinkeniene@gmail.com")
                .InsertPasword("D-20030309")
                .PressPrisijungtiButton()
                .AssertLoggedIn()
                .LogOut();

        }
    }
}
