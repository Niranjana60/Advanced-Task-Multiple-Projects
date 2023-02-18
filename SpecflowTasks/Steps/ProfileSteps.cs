using Advanced_task__test_project.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace Advanced_task__test_project.Steps
{
    [Binding]
    public class ProfileSteps : BaseStep
    {
        private readonly ProfilePage profilePage;
        private readonly LoginPage loginPage;

        public ProfileSteps()
        {
            profilePage = new ProfilePage(Driver);
            loginPage = new LoginPage(Driver);
        }


        [Then(@"I click on Add button below language tab")]
        public void ThenIClickOnAddButtonBelowLanguageTab()
        {
            profilePage.ClickOnAddNewButtonBelowLanguageTab();
        }

        [Given(@"I am logged in at ""(.*)"" as user ""(.*)"" with password ""(.*)""\.")]
        public void GivenIAmLoggedInAtAsUserWithPassword_(string url, string email, string password)
        {
            loginPage.QuickLogin(url, email, password);
        }


        [Given(@"I am at the Profile page")]
        public void GivenIAmAtTheProfilePage()
        {
            String text =profilePage.IsValidProfilePage();
            Assert.AreEqual("Profile",text);
        }

        [When(@"I Add (.*) and (.*) on Languages tab")]
        public void WhenIAddEnglishAndFluentOnLanguagesTab(string Language, string LanguageLevel)
        {
            profilePage.AddLanguages(Language, LanguageLevel);
        }
        
        [When(@"I click on Add button")]
        public void WhenIClickOnAddButton()
        {
            profilePage.ClickOnAddButton();
        }

        [Then(@"I Validate that (.*) and (.*) are added")]
        public void ThenIValidateThatEnglishAndFluentAreAdded(string Language, string LanguageLevel)
        {
            bool text = profilePage.ValidateLanguageIsAdded(Language);
            Assert.AreEqual(true, text);
            bool textone = profilePage.ValidateLanguageLevelIsAdded(LanguageLevel);
            Assert.AreEqual(true, textone);
        }


        [When(@"I click on Add New button below Skills tab")]
        public void WhenIClickOnAddNewButtonBelowSkillsTab()
        {
            profilePage.ClickOnAddNewButtonBelowSkillsTab();
        }


        [When(@"I click on Skills tab")]
        public void WhenIClickOnSkillsTab()
        {
            profilePage.ClickOnSkillsTab();
        }



        [When(@"I click on Add New button below Language")]
        public void WhenIClickOnAddNewButtonBelowLanguage()
        {
            profilePage.ClickOnAddNewButtonBelowLanguageTab();
        }

        [When(@"I click on Add button below language tab")]
        public void WhenIClickOnAddButtonBelowLanguageTab()
        {
            profilePage.ClickOnAddButton();
        }



        [When(@"I Add (.*) and (.*) on Skills tab")]
        public void WhenIAddAndOnSkillsTab(string skill, string skillLevel)
        {
            profilePage.AddSkill(skill, skillLevel);
        }

        [Then(@"I am at Profile Page")]
        public void ThenIAmAtProfilePage()
        {
            profilePage.IsValidProfilePage();
        }


        [Then(@"Validate that (.*) and (.*) are added\.")]
        public void ThenValidateThatCAndBeginnerAreAdded_(string skill, string level)
        {
            bool isSkillAdded = profilePage.ValidateSkillIsAdded(skill);
            Assert.AreEqual(true, isSkillAdded);
            bool isSkillLevelAdded = profilePage.ValidateSkillLevelIsAdded(level);
            Assert.AreEqual(true, isSkillLevelAdded);
        }

        [When(@"I click on Certification Tab")]
        public void WhenIClickOnCertificationTab()
        {
            profilePage.ClickOnCertificationsTab();
        }

        [When(@"I click on Add New button below certification tab")]
        public void WhenIClickOnAddNewButtonBelowCertificationTab()
        {
            profilePage.ClickOnAddNewButtonOfCertificationsTab();
        }

        [When(@"I Add (.*) and (.*) and (.*) on certification tab")]
        public void WhenIAddBarchAndAdobeAndOnCertificationTab(String CertificateorAward, String CertfiedFrom, String Year)
        {
            profilePage.AddCertifications(CertificateorAward, CertfiedFrom, Year);
        }

        [Then(@"I Validate that (.*) and (.*) and (.*)are added")]
        public void ThenIValidateThatBarchAndAdobeAndAreAdded(String CertificateorAward, String CertfiedFrom, String Year)
        {
            bool certificateOrAward = profilePage.ValidateCertificateorAward(CertificateorAward);
            Assert.AreEqual(true, certificateOrAward);

            bool certifiedFrom = profilePage.ValidateCertifiedFrom(CertfiedFrom);
            Assert.AreEqual(true, certifiedFrom);

            bool graduationYear = profilePage.ValidateCertifiedyear(Year);
            Assert.AreEqual(true, graduationYear);
        }

        [When(@"I click on Education tab")]
        public void WhenIClickOnEducationTab()
        {
            profilePage.ClickOnEducationTab();
        }
    

        [When(@"I click on Add New button of Education tab")]
        public void WhenIClickOnAddNewButtonOfEducationTab()
        {
            profilePage.ClickOnAddNewButtonOfEducationTab();
        }

        [When(@"I Add (.*) and (.*) and (.*) and (.*) and (.*) on Education tab")]
        public void WhenIAddJTSAndAngolaAndMFAAndVLSIAndOnEducationTab(string CollegeName, string Countryofcollege, string Title, string Degree, string Yearofgraduation)
        {
            profilePage.AddEducation(CollegeName, Countryofcollege, Title, Degree, Yearofgraduation);
        }

        [When(@"I click on Add button\.")]
        public void WhenIClickOnAddButton_()
        {
            profilePage.ClickOnADDButton();

        }

        [Then(@"Validate that (.*) and (.*) and (.*) and (.*) and (.*) are added")]
        public void ThenValidateThatJTSAndAngolaAndMFAAndVLSIAndAreAdded(String CollegeName, String Countryofcollege, String Title, String Degree, String Yearofgraduation)
        {
            bool collegename = profilePage.validatecollegename(CollegeName);
            Assert.AreEqual(true, collegename);
            bool countryOfCollege = profilePage.validatecountryofcollege(Countryofcollege);
            Assert.AreEqual(true, countryOfCollege);
            bool title = profilePage.validatetitle(Title);
            Assert.AreEqual(true, title);
            bool degree = profilePage.validatedegree(Degree);
            Assert.AreEqual(true, degree);
            bool yearOfGraduation = profilePage.validategraduationyear(Yearofgraduation);
            Assert.AreEqual(true, yearOfGraduation);

        }

        [When(@"I click on Edit button near Description box")]
        public void WhenIClickOnEditButtonNearDescriptionBox()
        {

            profilePage.ClickOnEditButtonNearDescriptionBox();
        }
    

        [When(@"I enter description in Description box")]
        public void WhenIEnterDescriptionInDescriptionBox()
        {
            profilePage.EnterDescriptionInDescriptionBox();

        }

        [When(@"I click on save button")]
        public void WhenIClickOnSaveButton()
        {
            profilePage.ClickOnSaveButton();
        }

        [Then(@"I validate that Description is saved")]
        public void ThenIValidateThatDescriptionIsSaved()
        {
          
            string Text = profilePage.ValidateDescriptionSuccessfullyEntered();
            Assert.AreEqual("Description has been saved successfully", Text);
        }

        [When(@"i click on Availability drop down list\.")]
        public void WhenIClickOnAvailabilityDropDownList_()
        {
            profilePage.ClickOnAvailabilityDropDownList();
        }

        [When(@"i select ""(.*)"" from availabilty drop down list\.")]
        public void WhenISelectFromAvailabiltyDropDownList_(string partTime)
        {
            profilePage.SelectPartTimeFromAvailabiltyDropDownList();
        }

        [Then(@"i validate that ""(.*)"" is selected from availability drop down list\.")]
        public void ThenIValidateThatIsSelectedFromAvailabilityDropDownList_(string partTime)
        {
            bool AvailText = profilePage.ValidateAvailabilityDropDown();
            Assert.AreEqual(true, AvailText);
        }

        [When(@"i click on Hours drop down list\.")]
        public void WhenIClickOnHoursDropDownList_()
        {
            profilePage.ClickOnHoursDropDown();
        }

        [When(@"i select ""(.*)"" from Hours drop down list\.")]
        public void WhenISelectFromHoursDropDownList_(string Lessthan30hoursaweek)
        {
            profilePage.SelectValueFromHoursDropDown();
        }


        [When(@"i click on Earn Target drop down list")]
        public void WhenIClickOnEarnTargetDropDownList()
        {
            profilePage.ClickOnEarnTargetIcon();
        }

        [When(@"i select ""(.*)"" from Target drop down list\.")]
        public void WhenISelectFromTargetDropDownList_(string Lessthan500permonth)
        {
            profilePage.SelectFromTargetDropDownList();

        }

        [Then(@"i validate that ""(.*)"" is selected from Target drop down list\.")]
        public void ThenIValidateThatIsSelectedFromTargetDropDownList_(string Lessthan500permonth)
        {
            bool EarnText = profilePage.ValidateTargetDropDownListSelected();
            Assert.AreEqual(true, EarnText);
        }

        [Given(@"I hover on ManageRequests and click Received requests")]
        public void GivenIHoverOnManageRequestsAndClickReceivedRequests()
        {
            profilePage.HoverOnManageRequestsAndClickOnReceivedRequests();
        }

        [Given(@"I hover on ManageRequests and click Send requests")]
        public void GivenIHoverOnManageRequestsAndClickSendRequests()
        {
            profilePage.HoverOnManageRequestsAndClickSendRequests();
        }

        [Given(@"I validate Send Requests")]
        public void GivenIValidateSendRequests()
        {
            profilePage.SendRequestValidate();
        }

        [Given(@"i click on chat link")]
        public void GivenIClickOnChatLink()
        {
            profilePage.ClickOnChat();
        }

        [Given(@"i type message in message box")]
        public void GivenITypeMessageInMessageBox()
        {
            profilePage.TypeMessageInMessageBox();
        }

        [Given(@"I click on send button")]
        public void GivenIClickOnSendButton()
        {
            profilePage.WhenIClickOnSendButton();
        }

        [Then(@"I validate the chat messages send")]
        public void ThenIValidateTheChatMessagesSend()
        {
            String text = profilePage.validatechatmessage();

            Assert.AreEqual("Hi there how are you doing?", text);
        }

        [Given(@"I click on searchskillsIcon")]
        public void GivenIClickOnSearchskillsIcon()
        {
            profilePage.ClickOnSearchskillsIcon();
        }

        [Given(@"I click on Graphics & Design Category under All categories")]
        public void GivenIClickOnGraphicsDesignCategoryUnderAllCategories()
        {
            profilePage.ClickOnGraphicsDesignCategoryUnderAllCategories();
        }

        [When(@"I click on image of the displayed person")]
        public void WhenIClickOnImageOfTheDisplayedPerson()
        {
            profilePage.ClickOnImageOfTheDisplayedPerson();
        }

        [Then(@"I validate that person is under Graphics & Design Category")]
        public void ThenIValidateThatPersonIsUnderGraphicsDesignCategory()
        {
            
            bool text = profilePage.ValidateThatPersonIsUnderGraphicsDesignCategory();

            Assert.AreEqual(true, text);
        }

        [Given(@"I click on LogoDesign subCategory under Graphics & Design")]
        public void GivenIClickOnLogoDesignSubCategoryUnderGraphicsDesign()
        {
            profilePage.ClickOnLogoDesignSubCategoryUnderGraphicsDesign();
        }

        [Then(@"I validate that person is under LogoDesign subCategory")]
        public void ThenIValidateThatPersonIsUnderLogoDesignSubCategory()
        {
            //profilePage.ThenIValidateThatPersonIsUnderLogoDesignSubCategory();

           bool text = profilePage.ThenIValidateThatPersonIsUnderLogoDesignSubCategory();

            Assert.AreEqual(true, text);
        }

        [Given(@"I click on Online under Filter")]
        public void GivenIClickOnOnlineUnderFilter()
        {
            profilePage.ClickOnOnlineUnderFilter();
        }

        [Then(@"I validate that person displayed is under Location type Online")]
        public void ThenIValidateThatPersonDisplayedIsUnderLocationTypeOnline()
        {
            bool text =profilePage.ValidatePersonDisplayedUnderLocationTypeOnline();
            Assert.AreEqual(true, text);
        }


        [Given(@"I click on serach skill icon")]
        public void GivenIClickOnSerachSkillIcon()
        {
            profilePage.ClickOnSearchskillsIcon();
        }

        [Given(@"i search for a user")]
        public void GivenISearchForAUser()
        {
            profilePage.WhenISearchForAUser();
        }

        [Given(@"i click on  displayed Image")]
        public void GivenIClickOnDisplayedImage()
        {
            profilePage.ClickOnDisplayedImage();
            
        }

        [Given(@"i type message in Request box")]
        public void GivenITypeMessageInRequestBox()
        {
          profilePage.WhenITypeMessageInRequestBox();
        }

        [Given(@"i click on Request button")]
        public void GivenIClickOnRequestButton()
        {
            profilePage.WhenIClickOnRequestButton();
        }

        [Given(@"i click on yes from alert pop up")]
        public void GivenIClickOnYesFromAlertPopUp()
        {
            profilePage.WhenIClickOnYesFromAlertPopUp();
        }
        [Then(@"My request is sent\.")]
        public void ThenMyRequestIsSent_()
        {
            string text = profilePage.RequestIsSentMessage();
            Assert.AreEqual("Request sent", text);
        }

        [When(@"I hover on Manage Requests and click on Sent Requests")]
        public void WhenIHoverOnManageRequestsAndClickOnSentRequests()
        {
            profilePage.HoverOnManageRequestsAndClickSendRequests();
        }


        [Then(@"i Validate the sent Requests")]
        public void ThenIValidateTheSentRequests()
        {
            profilePage.SendRequestValidate();
        }

        [Then(@"I hover on  Manage Requests and click on Received Requests to see the received requests")]
        public void ThenIHoverOnManageRequestsAndClickOnReceivedRequestsToSeeTheReceivedRequests()
        {
            profilePage.HoverOnManageRequestsAndClickOnReceivedRequests();
        }

        [Then(@"i validate the Received Requests")]
        public void ThenIValidateTheReceivedRequests()
        {
            profilePage.ReceivedRequestsvalidation();
        }

        [Given(@"i click shareskill button")]
        public void GivenIClickShareskillButton()
        {
            profilePage.ClickShareskillbuttonsecond();
        }

        [When(@"i hover on Managed requests and click on sent requests")]
        public void WhenIHoverOnManagedRequestsAndClickOnSentRequests()
        {
            profilePage.HoverOnManageRequestsAndClickSendRequests();
        }

        [Then(@"i view and validate the sent requests")]
        public void ThenIViewAndValidateTheSentRequests()
        {
            profilePage.SendRequestValidate();
        }


    }
}
