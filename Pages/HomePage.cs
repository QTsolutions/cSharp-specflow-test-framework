using OpenQA.Selenium;
using BaseFramework.Drivers;
using NUnit.Framework.Constraints;
using BaseFramework.Utilities;

namespace BaseFramework.Pages
{
    public class HomePage
    {
        IWebDriver driver;
        JsonReader jsonReader = new JsonReader();
        By createAccountBtnTop = By.XPath("//a[@data-prompt-popup-target=\"register\"]");

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoTo()
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(jsonReader.ReadData("url"));
        }

        public void ClickCreateAccountBtnTopNavigationBar()
        {
            driver.FindElement(createAccountBtnTop).Click();
        }

    }
}
