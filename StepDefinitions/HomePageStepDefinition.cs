using BaseFramework.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFramework.StepDefinitions
{
    public class HomePageStepDefinition
    {
        public HomePageStepDefinition() { }
        HomePage homePage = new HomePage();
        [Given(@"User is navigated to homepage")]
        public void GivenUserIsNavigatedToHomepage()
        {
            homePage.GoTo();
        }
    }
}
