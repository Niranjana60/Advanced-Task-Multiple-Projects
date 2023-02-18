
using Advanced_task__test_project.Pages;
using NUnit.Framework;
using TechTalk.SpecFlow;
//using System;


namespace Advanced_task__test_project.Steps
{
    [Binding]
    public class ManageListingSteps : BaseStep
    {
        private readonly ManageListingPage manageListingPage;
        private readonly LoginPage loginPage;
        private readonly ProfilePage profilePage;
        private readonly CommonElementsPage commonElementsPage;


        public ManageListingSteps()
        {
            manageListingPage = new ManageListingPage(Driver);
            loginPage = new LoginPage(Driver);
            profilePage = new ProfilePage(Driver);
           commonElementsPage = new CommonElementsPage(Driver);
        }

        [Given(@"I am logged in at url ""(.*)""")]
        public void GivenIAmLoggedInAtUrl(string url)
        {
            commonElementsPage.NavigateToUrl(url);
        }

        [When(@"i click on sign in")]
        public void WhenIClickOnSignIn()
        {
            loginPage.ClickSignInButton();
        }


        [When(@"I enter Login details")]
        public void WhenIEnterLoginDetails()
        {
            manageListingPage.LoginCommon();
        }

        [When(@"I am at the Profile page")]
        public void WhenIAmAtTheProfilePage()
        {
            profilePage.IsValidProfilePage();
        }


        [When(@"i click on Manage Listings link")]
        public void WhenIClickOnManageListingsLink()
        {
            manageListingPage.ClickOnManageListings();
        }

        [When(@"i am navigated to ListingManagement Page at url ""(.*)""")]
        public void WhenIAmNavigatedToListingManagementPageAtUrl(string url)
        {
            manageListingPage.NavigateToListingManagementPage(url);
        }


        [When(@"I click on edit icon from Manage listing table")]
        public void WhenIClickOnEditIconFromManageListingTable()
        {
            manageListingPage.ClickOnEditIconFromManageListing();
        }

        [When(@"I click on save button from bottom")]
        public void WhenIClickOnSaveButtonFromBottom()
        {
            manageListingPage.SaveEdittedTitle();
        }

        [When(@"i am navigated to  Service lising page")]
        public void WhenIAmNavigatedToServiceLisingPage()
        {
            string actualTitleOfServiceListingPage = manageListingPage.NavigatedToServiceLisingPage();
            Assert.AreEqual("ServiceListing", actualTitleOfServiceListingPage);
        }

        [When(@"i edit details in Title text box")]
        public void WhenIEditDetailsInTitleTextBox()
        {
            manageListingPage.EditDetailsInTitleTextBox();
        }
        
        [Then(@"i validate the edited title")]
        public void ThenIValidateTheEditedTitle()
        {
            string edittedTitle =manageListingPage.ValidateEdittedDetailsIsSaved();
            Assert.AreEqual("I provide writing scripts", edittedTitle);
        }

        [When(@"I click on signIn button")]
        public void WhenIClickOnSignInButton()
        {
            loginPage.ClickSignInButton();
        }

        [Then(@"I am at the Profile page")]
        public void ThenIAmAtTheProfilePage()
        {
            profilePage.IsValidProfilePage();
        }

        [When(@"I click on Manage Listings link from profile page")]
        public void WhenIClickOnManageListingsLinkFromProfilePage()
        {
            manageListingPage.ClickOnManageListings();
        }

        [When(@"I click on Delete icon from Manage listing table")]
        public void WhenIClickOnDeleteIconFromManageListingTable()
        {
            manageListingPage.ClickOnDeleteIcon();
        }



        [When(@"i click on yes button")]
        public void WhenIClickOnYesButton()
        {
            manageListingPage.ClickOnYes();
        }

        [Then(@"Validate that  user details should be deleted\.")]
        public void ThenValidateThatUserDetailsShouldBeDeleted_()
        {
            manageListingPage.ValidateDeleteManageListings();

            bool Text = manageListingPage.ValidateDeleteManageListings();
            Assert.AreEqual(true, Text);
        }

        


    }
}
