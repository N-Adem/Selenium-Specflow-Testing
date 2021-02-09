using System;
using NUnit.Framework;
using System.Threading;

namespace Selenium_Test1.tests
{
    class Jl_SignIn
    {
        public Jl_WebPages JlWebsite { get; } = new Jl_WebPages("chrome");

       /*[TestCase("something@gmail.com", "1234")]
       public void GivenThatImOnTheSignInPage_WhenIClickSignIn_IShouldHaveFilledInTheParams(string email, string password) {
           JlWebsite.HomePage.NavigateToSignInPage();
           JlWebsite.SignInPage.PopulateSigInPageWithLogInDetails(email, password);
           JlWebsite.SignInPage.SelectSignIn();
       }*/
    }
}
