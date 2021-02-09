using System;
using NUnit.Framework;
using System.Threading;
namespace Selenium_Test1.tests
{

    public class JL_SignIn
    {
        public Jl_WebPages JlWebsite { get; set; } 

        [SetUp]
        public void SetUp() {
            JlWebsite = new Jl_WebPages("chrome");
        }
/*
        [Test]
        public void GivenThatImOnTheHomePage_WhenIClickTheSiignInButton_IShouldLandOnTheSignInPage() {
            JlWebsite.HomePage.VisitHomePage();
            JlWebsite.HomePage.AllowAllCookies();
            Assert.That(JlWebsite.HomePage.GetPageTitle(), Does.Contain("John Lewis & Partners | Homeware, Fashion, Electricals & More"));
        }
       
        [Test]
        public void GivenThatImOnTheHomePage_WhenIHoverOverTheHomeAndGarden_IShouldBeAbleToAccessASetOfOptions() {
           //JlWebsite.HomePage.VisitHomePage();
           //JlWebsite.HomePage.AllowAllCookies();
            JlWebsite.HomePage.NavigateToHomeAndGardenInPage();
        }

        /*[Test]
        public void GivenThatImOnTheHomePages_WhenIClickTheHOmePageButton_IShouldBeAbleToAccessASetOfOptions()
        {
            JlWebsite.HomePage.NavigateToBeddingDepartment();
        }*/

        [TearDown]
        public void CleanUp() {

            JlWebsite.SeleniumDriver.Quit();
            JlWebsite.SeleniumDriver.Dispose();
        }


    }
}
