using Advanced_task__test_project.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Advanced_task__test_project.Steps
{
    [Binding]
    public class CommonElementsSteps:BaseStep
    {
        private readonly CommonElementsPage commonElementsPage;
        private readonly ProfilePage profilePage;
        private readonly LoginPage loginPage;
        private readonly ManageListingPage manageListingPage;
        public CommonElementsSteps()
        {
            manageListingPage = new ManageListingPage(Driver);
            commonElementsPage = new CommonElementsPage(Driver);
            profilePage = new ProfilePage(Driver);
            loginPage = new LoginPage(Driver);
        }

        [Given(@"I am logged in at ""(.*)"" to log into application")]
        public void GivenIAmLoggedInAtToLogIntoApplication(string url)
        {
            commonElementsPage.NavigateToUrl(url);
        }
    

        [When(@"I enter My Login Credentials")]
        public void WhenIEnterMyLoginCredentials()
        {
            manageListingPage.LoginCommon();
        }

        [When(@"I am at the Profile page now")]
        public void WhenIAmAtTheProfilePageNow()
        {
            profilePage.IsValidProfilePage();

            
        }

        [When(@"I Hover on Notification and click ShowLess")]
        public void WhenIHoverOnNotificationAndClickShowLess()
        {
            commonElementsPage.ShowLess();
        }


        [Then(@"i validate show Less")]
        public void ThenIValidateShowLess()
        {
            bool showLess = commonElementsPage.ValidateShowLess();

            Assert.IsTrue(showLess);
        }

        [When(@"I Hover on Notification and Click Load More")]
        public void WhenIHoverOnNotificationAndClickLoadMore()
        {
            commonElementsPage.Loadmorenotification();
        }

        [Then(@"i validate Load more")]
        public void ThenIValidateLoadMore()
        {
            bool loadMore = commonElementsPage.ValidateLoadMore();
            Assert.IsTrue(loadMore);
        }

        [When(@"i click sign in from login page")]
        public void WhenIClickSignInFromLoginPage()
        {
            loginPage.ClickSignInButton();
        }

        [When(@"I Hover on Notification and Delete Notification")]
        public void WhenIHoverOnNotificationAndDeleteNotification()
        {
            commonElementsPage.DeleteNotifications();
        }

        [Then(@"i validate that the notification is Deleted\.")]
        public void ThenIValidateThatTheNotificationIsDeleted_()
        {
            String text =commonElementsPage.ValidateDeleteNotification();

            Assert.AreEqual("Notification updated", text);
        }

        [When(@"I Hover on Notification and click select all")]
        public void WhenIHoverOnNotificationAndClickSelectAll()
        {
            commonElementsPage.SelectAll();
        }

        [Then(@"i validate select all")]
        public void ThenIValidateSelectAll()
        {
            bool text = commonElementsPage.SelectAllvalidation();

            Assert.AreEqual(true, text);
            
        }

        [When(@"i click on Unselect all")]
        public void WhenIClickOnUnselectAll()
        {
            commonElementsPage.UnSelectAll();

        }

        [Then(@"i validate Unselect all")]
        public void ThenIValidateUnselectAll()
        {
            

            bool text = commonElementsPage.UnSelectAllvalidation();

            Assert.AreEqual(false, text);
        }

        [When(@"I Hover on Notification and click see all")]
        public void WhenIHoverOnNotificationAndClickSeeAll()
        {
            commonElementsPage.HoverOnNotificationClickOnSeeAll();
        }


        [Then(@"i click inside a checkbox near Notification\.")]
        public void ThenIClickInsideACheckboxNearNotification_()
        {
            commonElementsPage.ClickInsideACheckboxNearNotification();
        }

        [Then(@"i click on Mark selection as Read icon")]
        public void ThenIClickOnMarkSelectionAsReadIcon()
        {
            commonElementsPage.ClickOnMarkAsRead();
        }

        [Then(@"i see the message Notification updated")]
        public void ThenISeeTheMessageNotificationUpdated()
        {
            string text =commonElementsPage.NotificationUpdated();

            Assert.AreEqual("Notification updated", text);
        }

        [Then(@"I validate Mark Selection as Read by font size\.")]
        public void ThenIValidateMarkSelectionAsReadByFontSize_()
        {
            string text =commonElementsPage.ValidateMarkSelectionAsReadByFontSize();
            Assert.AreEqual("400", text);
              
        }




    }
}
