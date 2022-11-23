
using BaseFramework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BaseFramework.Drivers

{
    public class SeleniumWebdriver
    {
        public static IWebDriver driver;
        public HomePage homePage ;
        public PersonalDetails personalDetails ;
        public SelectCountry selectCountry;
        public ProfessionalDetails professionalDetails;
        public SeleniumWebdriver()
        {

        }
        public void Setup()
        {
            driver = new ChromeDriver(@".\Drivers\");
            this.initClasses();
        }

        public void initClasses()
        {
            personalDetails = new PersonalDetails(driver);
            homePage = new HomePage(driver);
            selectCountry = new SelectCountry(driver);
            professionalDetails = new ProfessionalDetails(driver);

        }
        public  void QuitBrowser()
        {
            driver.Quit();
        }
    }
}
