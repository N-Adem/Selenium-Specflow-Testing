using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Selenium_Test1
{
    public class SeleniumDriverConfig
    {

        public IWebDriver Driver { get; set; }

        public SeleniumDriverConfig(string driverName, int pageLoadInSecs, int implicitWaitInSecs) {
            DriverSetUp(driverName, pageLoadInSecs, implicitWaitInSecs);
        }
        //This method will trigger another method that sets the driver config.
        public void DriverSetUp(string driverName, int pageLoadInSecs, int implicitWaitInSecs)
        {
            if (driverName.ToLower() == "chrome") {
                SetChromeDriver();
                SetDriverConfig(pageLoadInSecs, implicitWaitInSecs);
            } else if (driverName.ToLower() == "firefox") {
                SetFireFoxDriver();
                SetDriverConfig(pageLoadInSecs, implicitWaitInSecs);
            }

        }

        private void SetFireFoxDriver()
        {
            Driver = new FirefoxDriver();
        }

        private void SetChromeDriver()
        {
            Driver = new ChromeDriver();
            //run the test without the GUI
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("headless");
        }

        private void SetDriverConfig(int pageLoadInSecs, int implicitWaitInSecs)
        {
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadInSecs);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);
        }
    }
}
