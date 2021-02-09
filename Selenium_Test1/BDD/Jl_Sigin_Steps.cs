using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Selenium_Test1.BDD
{
    [Binding]
    public class Jl_SignInSteps
    {
        private Jl_WebPages JlWebsite { get; } = new Jl_WebPages("chrome");

        [Given(@"I am on the sign in page")]
        public void GivenIAmOnTheSignInPage()
        {
            JlWebsite.HomePage.VisitHomePage();
            JlWebsite.HomePage.AllowAllCookies();
            JlWebsite.HomePage.NavigateToSignInPage();
            Assert.That(JlWebsite.HomePage.GetPageTitle(), Does.Contain("Sign in | My Account | John Lewis & Partners"));
        }
        
        [Given(@"I have entered my email something@gmail\.com")]
        public void GivenIHaveEnteredMyemailSomethingGmail_Com()
        {
            JlWebsite.SignInPage.FillInSignInPageUserName("something@gmail.com");
        }
        
        [Given(@"I have entered my password (.*)")]
        public void GivenIHaveEnteredMyPassword(string p0)
        {   
            JlWebsite.SignInPage.FillInSignInPagePassword(p0);   
        }
        
        [When(@"I click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            JlWebsite.SignInPage.SelectSignIn();
        }
        
        [Then(@"then I should be an alert containing an error message ""(.*)""")]
        public void ThenThenIShouldBeAnAlertContainingAnErrorMessage(string p0)
        {
            //Assert.IsTrue(JlWebsite.SignInPage.SignInErrorMessage());
        }

        [AfterScenario]
        public void DisposeWebDriver() {
            JlWebsite.SeleniumDriver.Quit();
            JlWebsite.SeleniumDriver.Dispose();
        }
    }
}
