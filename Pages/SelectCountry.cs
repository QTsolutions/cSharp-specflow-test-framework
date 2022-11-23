using NUnit.Framework.Internal;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace BaseFramework.Pages
{
    public class SelectCountry
    {
        IWebDriver driver;
        public SelectCountry(IWebDriver driver)
        {
            this.driver = driver;
        }
        By continueBtn = By.XPath("(//span[text()='CONTINUE'])[2]");
        public void selectCountary()
        {
            Thread.Sleep(3000);
            String Country = "IND";
            SelectElement drpCountry = new SelectElement(driver.FindElement(By.Name("uccCountry")));
            drpCountry.SelectByValue(Country);
            Thread.Sleep(2000);
            driver.FindElement(continueBtn).Click();    

        }
    }
}
