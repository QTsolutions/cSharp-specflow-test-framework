using BaseFramework.Drivers;
using BaseFramework.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using BaseFramework.Utilities;

namespace BaseFramework.StepDefinitions
{
    [Binding]
    public class CreateAccountStepDefinitions
    {
       
        SeleniumWebdriver seleniumWebdriver= new SeleniumWebdriver();

        [Given(@"User is navigated to homepage")]
        public void GivenUserIsNavigatedToHomepage()
        {
            
            seleniumWebdriver.Setup();
            seleniumWebdriver.homePage.GoTo();
            
        }
        
        [Given(@"User clicks on create account button on top navigation bar")]
        public void GivenUserClicksOnCreateAccountButtonOnTopNavigationBar()
        {
            seleniumWebdriver.homePage.ClickCreateAccountBtnTopNavigationBar();
        }

        [Given(@"User able to enter email")]
        public void GivenUserAbleToEnterEamil()
        {
            seleniumWebdriver.personalDetails.EnterEmailCreateAccount();
        }

        [Given(@"User able to enter Country")]
        public void GivenUserAbleToEnterCountry()
        {
            seleniumWebdriver.selectCountry.selectCountary();
        }

        [Given(@"User able to enter professional details")]
        public void GivenUserAbleToEnterProfessionalDetails()
        {
            seleniumWebdriver.professionalDetails.SelectProfessionalCategory(); 
            seleniumWebdriver.professionalDetails.SelectPrimarySpeciality();
            seleniumWebdriver.professionalDetails.SelectPlace();
            seleniumWebdriver.professionalDetails.SelectRole();
            seleniumWebdriver.professionalDetails.EnterNameOfOrganization();
        }

        [Given(@"User able to enter personal details")]
        public void GivenUserAbleToEnterPersonalDetails()
        {
            seleniumWebdriver.personalDetails.EnterFirstNameCreaateAccountPage();
            seleniumWebdriver.personalDetails.EnterLastNameCreaateAccountPage();
            seleniumWebdriver.personalDetails.EnterPasswordCreaateAccountPage();
            seleniumWebdriver.personalDetails.ClickRememberMe();
        }

        [Then(@"Verify Create Acoount button")]
        public void ThenVerifyCreateAcoountButton()
        {
            seleniumWebdriver.personalDetails.VerifyCreateAccountButton();
        }
        
    }
}
