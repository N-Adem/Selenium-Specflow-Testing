using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Selenium_Test1
{
    public class HomePage
    {
        private IWebDriver _seleniumDriver;
        //Create a property that models the sign in link.
        private string HomePageUrl = AppConfigReader.baseUrl;

        private IWebElement _signInLink => _seleniumDriver.FindElement(By.LinkText("Sign in"));
        private IWebElement _menuHover => _seleniumDriver.FindElement(By.LinkText("Home & Garden"));
        private IWebElement _menuElementBedding => _seleniumDriver.FindElement(By.LinkText("Bedding"));
        private IWebElement _cookieAllow => _seleniumDriver.FindElement(By.ClassName("c-button-yMKB7"));
        private IWebElement _duvetSelect => _seleniumDriver.FindElement(By.LinkText("Duvets"));
        private IWebElement _duvetItemSelect => _seleniumDriver.FindElement(By.XPath("//img[@alt='Winter Duvets']"));
        public HomePage(IWebDriver seleniumDriver)
        {
            this._seleniumDriver = seleniumDriver;
        }

        //Go to homepage
        public void VisitHomePage() {
            _seleniumDriver.Navigate().GoToUrl(HomePageUrl);
        }
        //Navigate to the sign in page
        public void NavigateToSignInPage()
        {
            _signInLink.Click();
        }

        public void AllowAllCookies() {
            if (_cookieAllow != null)
            _cookieAllow.Click();
        }

        public void NavigateToHomeAndGardenInPage()
        {
            Actions actions = new Actions(_seleniumDriver); 
            actions.MoveToElement(_menuHover).Perform();           
            actions.MoveToElement(_menuElementBedding).Click().Build().Perform();
        }

        public void NavigateToBeddingDepartment()
        {
            //_duvetSelect.Click();
            //_duvetItemSelect.Click();
            //Thread.Sleep(5000);
        }

        public List<IWebElement> ListOfElementsForPurchasingDuvet() {
            List<IWebElement> duvetStepsElements = new List<IWebElement>();
            //duvetStepsElements.Add(_duvetSelect);
            //duvetStepsElements.Add();
            return duvetStepsElements;
        }
        
        //Return to title page of the browser
        public string GetPageTitle() {
            return _seleniumDriver.Title;
        }

    }
}
