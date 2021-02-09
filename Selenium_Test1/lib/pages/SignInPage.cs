using System;
using OpenQA.Selenium;

namespace Selenium_Test1
{
    public class SignInPage
    {
        private IWebDriver _seleniumDriver;
        private IWebElement _signInLink => _seleniumDriver.FindElement(By.Id("loginForm"));
        private IWebElement _signInUserName => _seleniumDriver.FindElement(By.Name("email"));
        private IWebElement _signInPassword => _seleniumDriver.FindElement(By.Id("password"));
        private IWebElement _signInErrorMessage => _seleniumDriver.FindElement(By.LinkText("Sorry, this account doesn’t seem to have a password"));

        public SignInPage(IWebDriver seleniumDriver)
        {
            this._seleniumDriver = seleniumDriver;
        }

        public void FillInSignInPageUserName(string email) {
            _signInUserName.SendKeys(email);
        }
        public void FillInSignInPagePassword(string password)
        {
            _signInPassword.SendKeys(password);
        }
        public bool SignInErrorMessage() {
            return _signInErrorMessage.Displayed ? true : false;
        }
        public void SelectSignIn() {
            _signInLink.Click();        
        }

  

    }
}
