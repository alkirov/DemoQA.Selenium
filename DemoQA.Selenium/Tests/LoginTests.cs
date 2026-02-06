using NUnit.Framework;
using DemoQA.Selenium.Pages;

namespace DemoQA.Selenium.Tests
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void InvalidLogin_ShowsErrorMessage()
        {
            var loginPage = new LoginPage(driver);
            loginPage.Open();

            loginPage.Login("wrongUser", "wrongPassword");

            var error = loginPage.getErrorMessege();
            Assert.That(error, Does.Contain("Invalid"));
        }

        [Test]
        public void EmptyLogin_ShowsErrorMessage()
        {
            var loginPage = new LoginPage(driver);
            loginPage.Open();

            loginPage.Login("", "");

            Assert.That(driver.Url, Does.Contain("/login"));           




        }
    }
}
