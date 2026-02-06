using OpenQA.Selenium;

namespace DemoQA.Selenium.Pages
{
    public class FormsPage : BasePage
    {
        public FormsPage(IWebDriver driver) : base(driver)
        {
        }

        private By FirstName = By.Id("firstName");
        private By LastName = By.Id("lastName");
        private By GenderMale = By.CssSelector("label[for='gender-radio-1']");
        private By SubmitButton = By.Id("submit");
        public  void Open()
        {
            driver.Navigate().GoToUrl("https://demoqa.com/automation-practice-form");

        }
        public void FillMandatoryFields()
        {
            driver.FindElement(FirstName).SendKeys("John");
            driver.FindElement(LastName).SendKeys("Doe");
            driver.FindElement(GenderMale).Click();
        }

        public void Submit()

        {

        JsClick(SubmitButton);
        }
    }
}
