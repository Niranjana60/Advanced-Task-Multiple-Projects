using Advanced_task__test_project.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Advanced_task__test_project.Steps
{
    [Binding]
    public class LoginPageSteps : BaseStep
    {
        
        private readonly ProfilePage profilePage;
        private readonly LoginPage loginPage;
        public LoginPageSteps()
        {
            profilePage = new ProfilePage(Driver);
            loginPage = new LoginPage(Driver);
        }


        [Given(@"i am in the loginpage at ""(.*)""")]
        public void GivenIAmInTheLoginpageAt(string loginPageUrl)
        {
            loginPage.Navigate(loginPageUrl);
        }

        [When(@"i click the Sign in Button")]
        public void WhenIClickTheSignInButton()
        {
            loginPage.ClickSignInButton();
        }

        [When(@"I enter (.*) and (.*)")]
        public void WhenIEnterAndPeppa(string email, string password)
        {
            loginPage.AddCredentials(email, password);
        }

        [When(@"I click the Login button")]
        public void WhenIClickTheLoginButton()
        {
            loginPage.ClickLoginButton();
        }

        [Then(@"I should be logged in successfully")]
        public void ThenIShouldBeLoggedInSuccessfully()
        {
            bool isLoggedin = loginPage.ValidateLogin();
            Assert.IsTrue(isLoggedin);

        }
    }
}

