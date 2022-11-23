using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BaseFramework.Utilities;
using OpenQA.Selenium;
using RazorEngine.Compilation.ImpromptuInterface.Dynamic;
using TechTalk.SpecFlow;
using Newtonsoft.Json;
using BaseFramework.Drivers;

namespace BaseFramework.Hooks
{
    [Binding]
    public class Hooks
    {
        private static ExtentTest featureName;
        private static ExtentTest scenario, step;
        private static ExtentReports extent;
        SeleniumWebdriver seleniumWebdriver = new SeleniumWebdriver();
        

        static string reportPath = System.IO.Directory.GetParent(@"../../../").FullName
            + Path.DirectorySeparatorChar + "Results" + Path.DirectorySeparatorChar + "Result_" + DateTime.Now.ToString("ddMMyyyyHHmmss");

        [BeforeScenario]
        public static void BeforeScenario()
        {
            Console.WriteLine("Starting browser");
            scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);
        }


        [AfterScenario]
        public void AfterScenario()
        {
            seleniumWebdriver.QuitBrowser();
            Console.WriteLine("Exiting browser");
            
        }


        [BeforeTestRun] 
        public  static void BeforeTestRun() 
        {
            //var HtmlReporter = new ExtentHtmlReporter("C:\\Users\\harshit jain\\Desktop\\C#\\cSharp-specflow-test-framework\\Reports\\Report.html");
            var HtmlReport = new ExtentHtmlReporter(reportPath);
            extent = new AventStack.ExtentReports.ExtentReports();
            extent.AttachReporter(HtmlReport);
        }
        [AfterTestRun] 
        public static void AfterTestRun() 
        {
            extent.Flush();
        }
        [BeforeFeature]
         public static void BeforeFeature()
        {
            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);
            
        }
        [AfterStep]
        public static void AfterStep()
        {
            scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
            if(ScenarioContext.Current.TestError==null)
            {
                step.Log(Status.Pass, ScenarioContext.Current.StepContext.StepInfo.Text);
            }
            else if(ScenarioContext.Current.TestError!=null)
            {
                
                step.Log(Status.Fail, ScenarioContext.Current.StepContext.StepInfo.Text);
            }
        }
        [BeforeStep]
        public static void BeforeStep()
        {
            step = scenario;
        }
    }
}