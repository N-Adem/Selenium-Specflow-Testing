using System;
using OpenQA.Selenium;

namespace Selenium_Test1
{
    //Superclass = the service object for all pages.
    public class Jl_WebPages
    {
        public IWebDriver SeleniumDriver { get; internal set; }
        public HomePage HomePage { get; internal set; }
        public SignInPage SignInPage { get; internal set; }
        public CreateUser CreateUser { get; internal set;  }

        public Jl_WebPages(string driverName, int pageLoadWaitInSecs = 10, int implicitWaitInSecs = 10 ) {
            //instantiate driver
            SeleniumDriver = new SeleniumDriverConfig(driverName, pageLoadWaitInSecs, implicitWaitInSecs).Driver;
            //instantiate page object with selenium driver 
            HomePage = new HomePage(SeleniumDriver);
            SignInPage = new SignInPage(SeleniumDriver);
            CreateUser = new CreateUser(SeleniumDriver);
        }

        public void DeleteCookies() {
            SeleniumDriver.Manage().Cookies.DeleteAllCookies();
        }
    }
}
