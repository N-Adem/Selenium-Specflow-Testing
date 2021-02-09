using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Selenium_Test1.BDD
{
    [Binding]
    public class Jl_Home_ShoppingSteps
    {
        private Jl_WebPages JlWebsite { get; } = new Jl_WebPages("chrome");

        [Given(@"I'm on the home page")]
        public void GivenIMOnTheHomePage()
        {
            JlWebsite.HomePage.VisitHomePage();
            JlWebsite.HomePage.AllowAllCookies();
            Assert.That(JlWebsite.HomePage.GetPageTitle(), Does.Contain("John Lewis & Partners | Homeware, Fashion, Electricals & More"));
        }

        [Given(@"I have selected the bedding department")]
        public void GivenIHaveSelectedTheBeddingDepartment()
        {
            JlWebsite.HomePage.NavigateToHomeAndGardenInPage();
            JlWebsite.HomePage.NavigateToBeddingDepartment();
        }
        
        [When(@"I select the items I want")]
        public void WhenISelectTheItemsIWant()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I will have added those items to the cart")]
        public void ThenIWillHaveAddedThoseItemsToTheCart()
        {
            ScenarioContext.Current.Pending();
        }
        


    }
}
