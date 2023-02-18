using Advanced_task__test_project.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Advanced_task__test_project.Steps
{
    [Binding]
    public class ShareSkillSteps:BaseStep
    { 

    private readonly ProfilePage profilePage;
    private readonly LoginPage loginPage;
    private readonly ShareskillPage shareSkillPage;
    private readonly CommonElementsPage commonElementsPage;
     private readonly ManageListingPage manageListingPage;

     public ShareSkillSteps()
    {
      profilePage = new ProfilePage(Driver);
      shareSkillPage = new ShareskillPage(Driver);
      loginPage = new LoginPage(Driver);
      commonElementsPage = new CommonElementsPage(Driver);
      manageListingPage = new ManageListingPage(Driver);

       }


        [Given(@"I am logged in at ""(.*)"" to log into application\.")]
        public void GivenIAmLoggedInAtToLogIntoApplication_(string url)
        {
            commonElementsPage.NavigateToUrl(url);
        }

        [Given(@"i click sign in from login page")]
        public void GivenIClickSignInFromLoginPage()
        {
            loginPage.ClickSignInButton();
        }

        [Given(@"I enter My Login Credentials")]
        public void GivenIEnterMyLoginCredentials()
        {
            manageListingPage.LoginCommon();
        }

        [When(@"i click shareskill button fronm profile page")]
        public void WhenIClickShareskillButtonFronmProfilePage()
        {
            profilePage.ClickShareskillbuttonsecond();
        }

        [Given(@"I am at the Profile page now")]
        public void GivenIAmAtTheProfilePageNow()
        {
            profilePage.IsValidProfilePage();
        }


        [When(@"i enter title from service listing page")]
        public void WhenIEnterTitleFromServiceListingPage()
        {
            shareSkillPage.EnterTitle();
        }

        [When(@"I enter Description")]
        public void WhenIEnterDescription()
        {
            shareSkillPage.EnterDescription();
        }

        [When(@"I select a category")]
        public void WhenISelectACategory()
        {
            shareSkillPage.SelectCategory();
        }

        [When(@"I select a subcategory")]
        public void WhenISelectASubcategory()
        {
            shareSkillPage.SelectSubCategory();
        }

        [When(@"I enter Tags")]
        public void WhenIEnterTags()
        {
            shareSkillPage.EnterTags();
        }

        [When(@"I select a service type")]
        public void WhenISelectAServiceType()
        {
            shareSkillPage.SelectServiceType();
        }

        [When(@"I select a Location type")]
        public void WhenISelectALocationType()
        {
            shareSkillPage.SelectLocationType();
        }

        [When(@"I Select a start date")]
        public void WhenISelectAStartDate()
        {
            shareSkillPage.EnterStartDate();

        }

        [When(@"I Select a end date")]
        public void WhenISelectAEndDate()
        {
            shareSkillPage.EnterEndDate();
        }

        [When(@"I Select a day")]
        public void WhenISelectADay()
        {
            shareSkillPage.SelectDay();
        }

        [When(@"I Select a skill trade")]
        public void WhenISelectASkillTrade()
        {
            shareSkillPage.SelectSkillTrade();
        }

        [When(@"I enter skill exchange")]
        public void WhenIEnterSkillExchange()
        {
            shareSkillPage.EnterSkillExchange();
        }

        [When(@"I Select fromn Active")]
        public void WhenISelectFromnActive()
        {
            shareSkillPage.Active();
        }

        [When(@"i click on save button")]
        public void WhenIClickOnSaveButton()
        {
            shareSkillPage.clickOnSaveButton();
        }

        [Then(@"I validate that new share skill is added successfully")]
        public void ThenIValidateThatNewShareSkillIsAddedSuccessfully()
        {
            String titlevalue = manageListingPage.ValidateSaveSkills();
            Assert.AreEqual("Hi I am a Documenter", titlevalue);

        }

      






    }
}
