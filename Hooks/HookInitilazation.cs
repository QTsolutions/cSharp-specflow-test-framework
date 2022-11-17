using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace BaseFramework.Hooks
{
    [Binding]
    public sealed class HookInitilazation
    {

   
        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Starting browser");
         
        }


        [AfterScenario]
        public void AfterScenario()
        {
            
            Console.WriteLine("Exiting browser");
        }
    }
}