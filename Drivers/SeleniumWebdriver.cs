
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BaseFramework.Drivers

{
    public class SeleniumWebdriver
    {
        public SeleniumWebdriver()
        {
        }

        IWebDriver driver = new ChromeDriver(@"C:\Users\harshit jain\Desktop\C#\cSharp-specflow-test-framework\Drivers\");
        public IWebDriver Setup()
        {
            return driver;
        }
        public  void QuitBrowser()
        {
           
            driver.Quit();
        }
    }
}
