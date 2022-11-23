using BaseFramework.Drivers;
using OpenQA.Selenium;
using System.Diagnostics;
using System.Configuration;

namespace BaseFramework.Pages
{
    public class PersonalDetails 
        
    {
        By createAccountButton = By.XPath("//span[text()='CREATE ACCOUNT']/..");
        By createAccountEmailField = By.XPath("//input[@name=\"uccEmail\"]");
        By firstNameCreateAccountPage = By.Name("uccFirstName");
        By lastNameCreateAccountPage = By.Name("uccLastName");
        By passwordCreateAccountPage = By.Name("uccPwd");
        By rememberMeBtnCreateAccountPage = By.XPath("//span[text()=\"Remember me\"]");

        public PersonalDetails(IWebDriver driver)
        {
            this.driver = driver;
        }
        IWebDriver driver;

        public void EnterEmailCreateAccount()
        {
            Random randomNumber = new Random();
            int number = randomNumber.Next(1,999);
            String str = "Siddharth" + number + "@gmail.com";
            driver.FindElement(createAccountEmailField).SendKeys(str);
            By continueBtn = By.XPath("//span[text()='CONTINUE']");
            driver.FindElement(continueBtn).Click();

        }
        public void EnterFirstNameCreaateAccountPage()
        {
            driver.FindElement(firstNameCreateAccountPage).SendKeys("Siddharth");
        }
        public void EnterLastNameCreaateAccountPage()
        {
            driver.FindElement(lastNameCreateAccountPage).SendKeys("Bhardwaj");
        }
        public void EnterPasswordCreaateAccountPage()
        {
            driver.FindElement(passwordCreateAccountPage).SendKeys("test@123");
        }
        public void ClickRememberMe()
        {
            driver.FindElement(rememberMeBtnCreateAccountPage).Click(); 
        }

        public void VerifyCreateAccountButton()
        {
            bool displayed = driver.FindElement(createAccountButton).Displayed;
            Debug.Assert(displayed,"Create ACoount button not displayed");
            
        }
    }
}
