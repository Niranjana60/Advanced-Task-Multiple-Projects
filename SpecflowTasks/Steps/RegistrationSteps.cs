using Advanced_task__test_project.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Advanced_task__test_project.Steps
{
    [Binding]
    public class RegistrationSteps : BaseStep
    {
       
        
        private readonly RegistrationPage registrationPage;
        private readonly CommonElementsPage commonElementsPage;

        public RegistrationSteps()
        {
            
          
            registrationPage = new RegistrationPage(Driver);
            commonElementsPage = new CommonElementsPage(Driver);
        }
        [Given(@"I am logged in at url ""(.*)"" to register")]
        public void GivenIAmLoggedInAtUrlToRegister(string url)
        {
            commonElementsPage.NavigateToUrl(url);
        }



        [Given(@"I am at Home page")]
        public void GivenIAmAtHomePage()
        {
            String actualTitle = registrationPage.AtHomePage();
            String expectedTitle = "Home";
            Assert.AreEqual(expectedTitle, actualTitle);
        }

        [When(@"I fill the Registration form")]
        public void WhenIFillTheRegistrationForm()
        {
            registrationPage.RegisterDetails();
        }

        [Given(@"I click on join")]
        public void GivenIClickOnJoin()
        {
            registrationPage.ClickJoinButton();
        }

        [When(@"I click on join button")]
        public void WhenIClickOnJoinButton()
        {
            registrationPage.clickOnJoinAfterfillingform();
        }



        [When(@"I click inside checkbox of I agree to terms and conditions")]
        public void WhenIClickInsideCheckboxOfIAgreeToTermsAndConditions()
        {
            registrationPage.ClickCheckbox();
        }
        
        [Then(@"I should see message Registration successfull")]
        public void ThenIShouldSeeMessageRegistrationSuccessfull()
        {
            String message = registrationPage.RegistrationSuccessfullMessage();
            Assert.AreEqual("Registration successful", message);
        }
    }
}
