using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selenium_Test1
{
    public class CreateUser
    {
        public Jl_WebPages JlWebsite { get; set; }
        private IWebDriver _seleniumDriver;
        private IWebElement _registerButton => _seleniumDriver.FindElement(By.XPath("//button[contains(.,'Create account')]"));
        private IWebElement _signInEmail => _seleniumDriver.FindElement(By.Id("email"));
        private IWebElement _signInPassword => _seleniumDriver.FindElement(By.Id("passwordCreate"));
        private IWebElement __homeToCreateUserPageButton => 
            _seleniumDriver.FindElement(By.XPath("//button[contains(.,'Create an account')]"));
        private IWebElement _createUserNewsLetterSelection =>
            _seleniumDriver.FindElement(By.XPath("//label[contains(.,'No, let me choose')]"));

        public CreateUser(IWebDriver seleniumDriver) {
            _seleniumDriver = seleniumDriver;
        }

        public void NavigateToCreateUserPage() {
            __homeToCreateUserPageButton.Click();
        }

        public void FillInCreateUserEmail(string email)
        {
            _signInEmail.SendKeys(email);
        }

        public void FillInCerateUserPassword(string password)
        {
            _signInPassword.SendKeys(password);
        }

        public void SelectNewsLetterOptionAndCreateAccount()
        {
            _createUserNewsLetterSelection.Click();
            _registerButton.Click();
        }

        public string GetPageTitle()
        {
            return _seleniumDriver.Title;
        }

    }
}
