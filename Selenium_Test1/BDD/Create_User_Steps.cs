using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Selenium_Test1.BDD
{
    [Binding]
    public class Create_UserSteps
    {
        private Jl_WebPages JlWebpages { get; } = new Jl_WebPages("chrome");

        [Given(@"That I don't have an account")]
        public void GivenThatIDonTHaveAnAccount()
        {
            JlWebpages.HomePage.VisitHomePage();
            JlWebpages.HomePage.AllowAllCookies();
            Assert.That(JlWebpages.HomePage.GetPageTitle(), Does.Contain("John Lewis & Partners | Homeware, Fashion, Electricals & More"));
        }
        
        [Given(@"I select the create an acccount option")]
        public void GivenISelectTheCreateAnAcccountOption()
        {
            JlWebpages.HomePage.NavigateToSignInPage();
            JlWebpages.CreateUser.NavigateToCreateUserPage();
            Assert.That(JlWebpages.CreateUser.GetPageTitle(), Does.Contain("Registration | My Account | John Lewis & Partners"));
        }
        
        [Given(@"I add an email (.*)")]
        public void GivenIAddAnEmail(string p0)
        {
            JlWebpages.CreateUser.FillInCreateUserEmail(p0);
        }
        
        [Given(@"I add a password (.*)")]
        public void GivenIAddAPassword(string p0)
        {
            JlWebpages.CreateUser.FillInCerateUserPassword(p0);
        }
        
        [When(@"I select create an account")]
        public void WhenISelectCreateAnAccount()
        {
            JlWebpages.CreateUser.SelectNewsLetterOptionAndCreateAccount();
        }
        
        [Then(@"Account created successfully")]
        public void ThenAccountCreatedSuccessfully()
        {
            //
        }
        [AfterScenario]
        public void DisposeWebDriver()
        {
            JlWebpages.SeleniumDriver.Quit();
            JlWebpages.SeleniumDriver.Dispose();
        }
    }
}
