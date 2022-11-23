using OpenQA.Selenium;
using BaseFramework.Drivers;
using NUnit.Framework.Constraints;

namespace BaseFramework.Pages
{
    public class HomePage
    {
        IWebDriver driver;
        By createAccountBtnTop = By.XPath("//a[@data-prompt-popup-target=\"register\"]");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoTo()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.nejm.org/");
        }

        public void ClickCreateAccountBtnTopNavigationBar()
        {
            driver.FindElement(createAccountBtnTop).Click();
        }

    }
}
