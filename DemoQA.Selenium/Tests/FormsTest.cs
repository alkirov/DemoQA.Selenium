using NUnit.Framework;
using DemoQA.Selenium.Pages;

namespace DemoQA.Selenium.Tests
{
    public class FormsTest : BaseTest
    {
        [Test]
        public  void SubmitForm_WithMandatoryFields_DoNotCrash()
        {
            var formPage = new FormsPage(driver);
            formPage.Open();

            formPage.FillMandatoryFields();
            formPage.Submit();

            Assert.Pass("Form submitted without errors");
        }
    }
}
