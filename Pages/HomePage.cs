using OpenQA.Selenium;
using BaseFramework.Drivers;


namespace BaseFramework.Pages
{
    internal class HomePage
    {
        IWebDriver driver;
        SeleniumWebdriver seleniumWebdriver = new SeleniumWebdriver();

        public void GoTo()
        {
            driver = seleniumWebdriver.Setup();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.nejm.org/");
        }
    }
}
