using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Xml.Serialization;

namespace DemoQA.Selenium.Pages
{
    public class BasePage
    {
        protected IWebDriver driver;
        protected WebDriverWait wait;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        protected void ScrollIntoView(IWebElement element)
        {
            ((IJavaScriptExecutor)driver)
               .ExecuteScript("arguments[0].scrollIntoView(true);", element);
        }

        protected void WaitForElementVisible (By locator)
        {
            wait.Until(d => d.FindElement(locator).Displayed);
        }

        protected void Click(By locator)
        {
            var element = driver.FindElement(locator);
            ScrollIntoView(element);
            element.Click();
        }
        protected void JsClick(By locator)
        {
            var element = driver.FindElement(locator);
            ScrollIntoView(element);

            ((IJavaScriptExecutor)driver)
                .ExecuteScript("arguments[0].click();", element);
        }
    }
}
