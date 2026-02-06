using OpenQA.Selenium;

namespace DemoQA.Selenium.Pages
{
    public class RegisterPage : BasePage
    {
        public RegisterPage(IWebDriver driver) : base(driver)
        { 
        }
        private By FirstName = By.Id("firstname");
        private By LastName = By.Id("lastname");
        private By UserName = By.Id("userName");
        private By Password = By.Id("password");
        private By RegisterButton = By.Id("register");

        public void Open()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/register");
        }

        public (string Username, string Password) RegisterRandomUser()
        {
            string username = $"user_{System.Guid.NewGuid():N}".Substring(0, 10);
            string password = "Password123!";

            driver.FindElement(FirstName).SendKeys("John");
            driver.FindElement(LastName).SendKeys("Doe");
            driver.FindElement(UserName).SendKeys(username);
            driver.FindElement(Password).SendKeys(password);

            JsClick(RegisterButton);

            return (username, password);
        }
    }
}
