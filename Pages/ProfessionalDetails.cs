using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseFramework.Pages
{
   
    public class ProfessionalDetails
    {
        IWebDriver driver;

        By primarySpecialty = By.XPath("//div[@data-result=\"Addiction Medicine\"]");
        By categoryDropdown = By.Name("uccProfessionalCategory");
        By primarySpecialityDropdown = By.Name("uccSpecialty");
        By roleDropdown = By.Name("uccRole");
        By placeOfWork = By.Name("uccPlaceOfWork");
        By nameOfOrg = By.Name("uccNameOfOrg");
        By continueBtn = By.XPath("(//span[text()='CONTINUE'])[3]");

        public ProfessionalDetails(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        public void SelectProfessionalCategory()
        {
            String professionalCategory = "Physician";
            SelectElement category = new SelectElement(driver.FindElement(categoryDropdown));
            category.SelectByText(professionalCategory);
        }
        public void SelectPrimarySpeciality()
        {
           
            driver.FindElement(primarySpecialityDropdown).Click();
            driver.FindElement(primarySpecialty).Click();   
            
        }
        public void SelectRole()
        {
            String role = "Manager";
            SelectElement selectRole = new SelectElement(driver.FindElement(roleDropdown));
            selectRole.SelectByText(role);
        }
        public void SelectPlace()
        {
            String place = "Clinic";
            SelectElement selectPlace = new SelectElement(driver.FindElement(placeOfWork));
            selectPlace.SelectByText(place);
        }
        public void EnterNameOfOrganization()
        {
            
            driver.FindElement(nameOfOrg).SendKeys("ABC PVT LTD");
            driver.FindElement(continueBtn).Click();
        }
    }
}
