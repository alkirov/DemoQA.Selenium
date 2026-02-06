using NUnit.Framework;
using DemoQA.Selenium.Pages;

namespace DemoQA.Selenium.Tests
{
    public class E2ETests : BaseTest
    {
        [Test]
        public void UserCanRegisterAndLoginSuccessfully()
        {
            var registerPage = new RegisterPage(driver);
            registerPage.Open();    

            var user = registerPage.RegisterRandomUser();

            var loginPage = new LoginPage(driver);
            loginPage.Open();

            loginPage.Login(user.Username, user.Password);

            Assert.That(driver.Url, Does.Contain("/login"));
        }
    }
}
