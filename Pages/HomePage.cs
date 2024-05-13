using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using ProjectMarsAutomation.utitlities;




namespace ProjectMarsAutomation.Pages
{
    internal class HomePage:CommonDriver
    {
        //Finding for elements
        private IWebElement welcomeText => driver.FindElement(By.XPath(e_welcomeText));

        //Element for wait
        private string e_welcomeText = "//*[@id=\"account-profile-section\"]/div/div[1]/div[2]/div/span";

        private IWebElement LanguageButton = driver.FindElement(By.XPath("//a[@class='item active' and @data-tab='first' and text()='Languages']"));
         public void NavigateToLanguageTab()
        {
           
            LanguageButton.Click();

        }

      
        public string getWelcomeText()
        {

            Waitutilities.WaitToBeVisible(driver, "XPath", e_welcomeText, 3);
            return welcomeText.Text;
        }

    }
}
