using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DemoQA.Selenium.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }


        private IWebElement Username => driver.FindElement(By.Id("userName"));
        private IWebElement Password => driver.FindElement(By.Id("password"));
        private IWebElement LoginButton => driver.FindElement(By.Id("login"));
        private IWebElement ErrorMessage => driver.FindElement(By.Id("name"));

        public void Open()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/login");
        }

        public void Login(string username, string password)
        {
            Username.Clear();
            Username.SendKeys(username);    

            Password.Clear();
            Password.SendKeys(password);

            ((IJavaScriptExecutor)driver)
    .ExecuteScript("arguments[0].scrollIntoView(true);", LoginButton);

            LoginButton.Click();
        }

        public string getErrorMessege()
        {
            wait.Until(d => ErrorMessage.Displayed);
            return ErrorMessage.Text;
        }
    }
}
