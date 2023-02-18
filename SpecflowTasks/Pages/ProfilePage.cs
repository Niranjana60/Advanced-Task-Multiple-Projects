using Advanced_task__test_project.Pages;
//using Advanced_task_with_specflow.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Advanced_task__test_project.Pages
{

    public class ProfilePage : BasePage
    {
        public ProfilePage(IWebDriver driver) : base(driver)
        {
        }

        #region  Initialize Web Elements
        [FindsBy(How = How.XPath, Using = "//strong[normalize-space()='Location']")]
        private IWebElement Location { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Share Skill')]")]
        private IWebElement ShareSkillButton { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[1]")]
        private IWebElement FullTime { get; set; }

        //avilability drop down part time
        [FindsBy(How = How.XPath, Using = "//*[@id='account - profile - section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/select/option[2]")]
        private IWebElement PartTime { get; set; }

        //Add New
        [FindsBy(How = How.XPath, Using = "//div[@class='ui bottom attached tab segment active tooltip-target']//div[contains(@class,'ui teal button')][normalize-space()='Add New']")]
        private IWebElement addNewButtonOfLanguageTab { get; set; }

        //Add language
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Language']")]
        private IWebElement AddLanguage { get; set; }

        //Language dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='level']")]
        private IWebElement Languagedropdown { get; set; }

        //Add button language
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement addLanguage { get; set; }

        //languagelabel
        [FindsBy(How = How.XPath, Using = "//td[normalize-space()='French']")]
        private IWebElement languagelabel { get; set; }

        //languagelevel
        [FindsBy(How = How.XPath, Using = "//td[normalize-space()='Basic']")]
        private IWebElement languagelevel { get; set; }

        //skills tab
        // [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")]
        private IWebElement skilltab { get; set; }

        //add button
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement addbutton { get; set; }

        //add
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Skill']")]
        private IWebElement addskill { get; set; }

        //Skill dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select")]
        private IWebElement skilldropdown { get; set; }

        //skill add
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]")]
        private IWebElement skilladd { get; set; }
        //skill label
        [FindsBy(How = How.XPath, Using = "//td[normalize-space()='Ruby']")]
        private IWebElement skillabel { get; set; }

        //skill level
        [FindsBy(How = How.XPath, Using = "//td[normalize-space()='Intermediate']")]
        private IWebElement skillevel { get; set; }

        //Education tab
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]")]
        private IWebElement Educationtab { get; set; }

        //Add new of Education
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/thead/tr/th[6]/div")]
        private IWebElement addnewOfEducationTab { get; set; }

        //college/university name
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='College/University Name']")]
        private IWebElement collegename { get; set; }

        //country of college/university dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='country']")]
        private IWebElement collegecountrydropdown { get; set; }
        //Title dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='title']")]
        private IWebElement titleDropdown { get; set; }
        //Degree
        [FindsBy(How = How.XPath, Using = "//input[@name='degree']")]
        private IWebElement Degree { get; set; }
        //year of graduation dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='yearOfGraduation']")]
        private IWebElement yearOfGraduationDropdown { get; set; }
        //Add Education
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]")]
        private IWebElement addEducation { get; set; }
        //college namevalidation

        [FindsBy(How = How.XPath, Using = "//td[normalize-space()='Dublin university']")]
        private IWebElement collegenamevalidation { get; set; }
        //country of collegevalidation
        [FindsBy(How = How.XPath, Using = "//td[normalize-space()='Ireland']")]
        private IWebElement countryofcollegevalidation { get; set; }
        //titlevalidation
        [FindsBy(How = How.XPath, Using = "//td[normalize-space()='Associate']")]
        private IWebElement titlevalidation { get; set; }
        //Degreeevalidation
        [FindsBy(How = How.XPath, Using = "//td[normalize-space()='VLSI']")]
        private IWebElement Degreeevalidation { get; set; }
        //certification tab
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]")]
        private IWebElement certificationTab { get; set; }
        //AddNewOfCertification
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div")]
        private IWebElement addNewCertification { get; set; }

        //certificate or award
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Certificate or Award']")]
        private IWebElement certificateOrAward { get; set; }
        //certified from
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Certified From (e.g. Adobe)']")]
        private IWebElement certifiedfrom { get; set; }
        //year of certification
        [FindsBy(How = How.XPath, Using = "//select[@name='certificationYear']")]
        private IWebElement yearOfCertificationDropdown { get; set; }
        //add button certification
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]")]
        private IWebElement addcertification { get; set; }
        //Certificateaddedvalidation
        [FindsBy(How = How.XPath, Using = "//td[normalize-space()='Barch']")]
        private IWebElement Certificateaddedvalidation { get; set; }
        //Certifiedfromvalidation
        [FindsBy(How = How.XPath, Using = "//td[normalize-space()='Adobe']")]
        private IWebElement Certifiedfromvalidation { get; set; }
        //YearValidation
        [FindsBy(How = How.XPath, Using = "//td[normalize-space()='2017']")]
        private IWebElement YearValidation { get; set; }

        //Hi peppa link
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span/div/a[2]")]
        private IWebElement HiPeppa { get; set; }

        //change password
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Change Password']")]
        private IWebElement changepassword { get; set; }

        //old password
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement oldpassword { get; set; }

        //new password
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement newpassword { get; set; }

        //confirm password
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement confirmpassword { get; set; }

        //save
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement save { get; set; }

        //sign out
        [FindsBy(How = How.XPath, Using = "")]
        private IWebElement signout { get; set; }
        //allcategorieslink
        [FindsBy(How = How.XPath, Using = "//div[@class='ui secondary menu']//i[@class='search link icon']")]
        private IWebElement allcategories { get; set; }
        //[FindsBy(How = How.XPath, Using = "(//span/i[@class='right floated outline small write icon'])[2]")]
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i")]
        private IWebElement Hoursediticon { get; set; }
        //Earntarget icon
        //[FindsBy(How = How.XPath, Using = "(//span/i[@class='right floated outline small write icon'])[3]")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i")]
        private IWebElement Earntargeticon { get; set; }
        // [FindsBy(How = How.XPath, Using = "span[normalize - space() = 'Part Time']//i[@class='right floated outline small write icon']")]
        [FindsBy(How = How.XPath, Using = "(//span/i[@class='right floated outline small write icon'])[1]")]
        private IWebElement availabilityicon { get; set; }
        //Availabilityelement
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyType']")]
        private IWebElement availabilityelement { get; set; }
        //Hourelement
        //[FindsBy(How = How.XPath, Using = "//select[@name='availabiltyHour']")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/select")]
        private IWebElement Hourelement { get; set; }
        //EarnTargetelement
        [FindsBy(How = How.XPath, Using = "//select[@name='availabiltyTarget']")]
        private IWebElement EarnTargetelement { get; set; }
        //availabilityvalidationelement
        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Part Time')]")]
        private IWebElement availabilityvalidationelement { get; set; }
        //hourvalidationelement
        //[FindsBy(How = How.XPath, Using = "//span[normalize-space()='Less than 30hours a week']")]
        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Less than 30hours a week')]")]
        private IWebElement hourvalidationelement { get; set; }
        //earntargetvalidationelement
        //[FindsBy(How = How.XPath, Using = "(//div[@class='right floated content']/span)[3]")]

        //[FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/select/option[1]")]
        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Less than $500 per month')]")]
        private IWebElement Earntargetvalidationelement { get; set; }
        //Description 
        //[FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")]
        //private IWebElement Descriptionbox { get; set; }
        //Descriptionbox 
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/div[1]/textarea")]
        private IWebElement Descriptionbox { get; set; }
        //Description icon
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")]
        private IWebElement Descriptionicon { get; set; }
        ////Description success
        [FindsBy(How = How.XPath, Using = "//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']")]
        //private IWebElement Descriptionsuccess { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='ns-box-inner']")]
        private IWebElement Descriptionsuccess { get; set; }
        //Description savebutton
        [FindsBy(How = How.XPath, Using = "//button[@type='button']")]
        private IWebElement Descriptionsavebutton { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement Add { get; set; }
        //Degree
        [FindsBy(How = How.XPath, Using = "//input[@name='degree']")]
        private IWebElement degree { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='ui teal button']")]
        private IWebElement AddNewButtonofSkillTab { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[1]/div/div[2]/a")]
        private IWebElement ShareskillButtonFromProfile { get; set; }
        [FindsBy(How = How.LinkText, Using = "Share Skill")]
        private IWebElement ShareskillButtonFromProfileSecond { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Received Requests']")]
        private IWebElement Receivedrequest { get; set; }
        //Acceptbutton
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/button[1]")]
        private IWebElement Acceptbutton { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[1]/div/div[1]")]
        private IWebElement Managerequest { get; set; }
        //Requestbutton
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'button')]")]
        private IWebElement Requestbutton { get; set; }

        //SentRequests
        [FindsBy(How = How.LinkText, Using = "Sent Requests")]
        private IWebElement Sendrequests { get; set; }
        //yesbutton
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Yes']")]
        private IWebElement yes { get; set; }
        //button[normalize-space()='Yes']
        //no of rows
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr")]
        private IList<IWebElement> rownumber { get; set; }
        //no of columns
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td")]
        private IList<IWebElement> columnsnumber { get; set; }
        //1st row
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[1]/div/div[1]")]
        private IWebElement firstrow { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Chat']")]
        private IWebElement Chat { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='chatTextBox']")]
        private IWebElement messagebox { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[20]//div[1]//div[1]//span[1]")]
        private IWebElement Messageboxmessage { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@id='btnSend']")]
        private IWebElement SendMessage { get; set; }
        //searchskilltextbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search skills']")]
        private IWebElement Searchskilltextbox { get; set; }
        //searchicon
        [FindsBy(How = How.XPath, Using = "//div[@class='ui secondary menu']//i[@class='search link icon']")]
        private IWebElement searchicon { get; set; }
        [FindsBy(How = How.XPath, Using = "//p[@class='row-padded']")]
        private IWebElement categoryvalidation { get; set; }
        //subcategoryvalidation
        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='Logo Design']")]
        private IWebElement subcategoryvalidation { get; set; }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Graphics & Design')]")]
        private IWebElement GraphicsDesignLink { get; set; }
        //searchimage
        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='I design beautiful logos']")]
        private IWebElement searchedImage { get; set; }
        //[FindsBy(How = How.LinkText, Using = "Graphics & Design")]
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Graphics & Design')]")]
        private IWebElement GraphicsDesign { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='ui container']//div[@class='row-padded']//a[3]")]
        private IWebElement LogoDesignLink { get; set; }
        [FindsBy(How = How.LinkText, Using = "Logo Design")]
        private IWebElement LogoDesign { get; set; }
        //onlinefilter
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Online']")]
        private IWebElement onlinefilter { get; set; }
        //onlinefiltervalidation
        [FindsBy(How = How.XPath, Using = "//div[normalize-space()='Online']")]
        private IWebElement onlinefiltervalidation { get; set; }
        //onsitefilter
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Onsite']")]
        private IWebElement onsitefilter { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Online')]")]
        private IWebElement Online { get; set; }
      
        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox']")]
        private IList<IWebElement> ListOfCheckBoxes { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox']")]
        private IWebElement checkboxicon { get; set; }
        [FindsBy(How = How.XPath, Using = "//i[@class='trash icon']")]
        private IWebElement Deleteicon { get; set; }
        //DeleteSuccessmessage
        [FindsBy(How = How.XPath, Using = "//div[@class='ns-box-inner']")]
        private IWebElement DeleteSuccessmessage { get; set; }
        //selectallicon
        [FindsBy(How = How.XPath, Using = "//i[@class='mouse pointer icon']")]
        private IWebElement selectallicon { get; set; }
        //unselectallicon
        [FindsBy(How = How.XPath, Using = "//i[@class='ban icon']")]
        private IWebElement unselectallicon { get; set; }
        //searchuser
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search user']")]
        private IWebElement searchuser { get; set; }
        //searchuserimage
        [FindsBy(How = How.XPath, Using = "//body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/section[1]/div[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[2]/a[1]/img[1]")]
        private IWebElement searchuserimage { get; set; }
        //Requestmessagebox
        [FindsBy(How = How.XPath, Using = "//*[@id='service-detail-section']/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div/div[1]/textarea")]
        private IWebElement Requestmessengerbox { get; set; }
        //RequestsentMessage
        [FindsBy(How = How.XPath, Using = "//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']")]
        private IWebElement RequestSentMessage { get; set; }
        //blippiuser
        [FindsBy(How = How.XPath, Using = "//*[@id='service-search-section'/div[2]/div/section/div/div[1]/div[3]/div[1]/div/div[2]/div[1]")]
        private IWebElement Blippiuser { get; set; }
        //shareskillbutton
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Share Skill')]")]
        private IWebElement ShareSkillButtonNew { get; set; }
        //shareskillbutton
        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div/section[1]/div/div[2]/a")]
        private IWebElement Sb { get; set; }
        //searchimage
        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='I design beautiful logos']")]
        private IWebElement Searchimage { get; set; }

        #endregion

        public string IsValidProfilePage()
        {
          
            String actualtitle = Driver.Title;

            wait(4000);
            return actualtitle;
            
            //ElementExists("XPath", "//*[@id='account-profile-section']/div/section[1]/div/div[2]/a", 5);
            //GlobalDefinitions.ElementExists("X Path", "//a[contains(text(),'Share Skill')]", 8);
            // GlobalDefinitions.ElementExists("X Path", "//*[@id='account-profile-section']/div/section[1]/div/div[2]/a", 5);
            // IWebElement shareskill = driver.FindElement(By.XPath("//a[contains(text(),'Share Skill')]"));
            //return ShareskillButtonFromProfile.Text == "Share Skill";
  

        }

        public void ClickShareskillbuttonsecond()
        {
            
            ElementExists("XPath", "//*[@id='account-profile-section']/div/section[1]/div/div[2]/a", 4);
            ShareSkillButton.Click();
        }
       
        public void ClickOnAddNewButtonBelowLanguageTab()
        {
            IWebElement addNewButtonOfLanguageTab = Driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            addNewButtonOfLanguageTab.Click();
            //Thread.Sleep(2000);
        }

        public void AddLanguages(String Language, String LanguageLevel)
        {

            addLanguage.SendKeys(Language);
            
            var selectElement = new SelectElement(Languagedropdown);

            selectElement.SelectByValue(LanguageLevel);
            
        }

        public void ClickOnAddButton()
        {
            
            addbutton.Click();
            
        }
        public bool ValidateLanguageIsAdded(string Language)
        {

            ElementExists("XPath", "//td[normalize-space()='" + Language + "']", 2);
            IWebElement LanguageLabel = Driver.FindElement(By.XPath("//td[normalize-space()='" + Language + "']"));
            bool isLanguagePresent = LanguageLabel.Text.Equals(Language);
            return isLanguagePresent;
        }

        public bool ValidateLanguageLevelIsAdded(string LanguageLevel)
        {

           
            IWebElement languageLevelLabel = Driver.FindElement(By.XPath("//td[normalize-space()='" + LanguageLevel + "']"));
            bool isLevelPresent = languageLevelLabel.Text.Equals(LanguageLevel);
            return isLevelPresent;
        }

  
        public void ClickOnSkillsTab()
        {
          
            ElementExists("XPath", "//a[contains(text(),'Skills')]", 3);
            //ElementExists("XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 3);
            skilltab.Click();
        }

        public void ClickOnAddNewButtonBelowSkillsTab()
        {
            AddNewButtonofSkillTab.Click();
        }
        public void AddSkill()
        {
            addskill.Click();
        }
        public void AddSkill(String Skill, String level)
        {
            addskill.SendKeys(Skill);
            var selectElement = new SelectElement(skilldropdown);
            selectElement.SelectByValue(level);

        }

        public void AddEducation(String CollegeName, String Countryofcollege, String Title, String Degree, String Yearofgraduation)
        {

            collegename.SendKeys(CollegeName);

            var selectCountrydropdown = new SelectElement(collegecountrydropdown);
            selectCountrydropdown.SelectByText(Countryofcollege);

            var titleDropDowncollege = new SelectElement(titleDropdown);
            titleDropDowncollege.SelectByText(Title);

            degree.SendKeys(Degree);

            var yearOfGraduation = new SelectElement(yearOfGraduationDropdown);
            yearOfGraduationDropdown.SendKeys(Yearofgraduation);

          

        }

        public bool ValidateSkillIsAdded(string skill)
        {
            wait(2000);
            IWebElement skillLabel = Driver.FindElement(By.XPath("//td[normalize-space()='" + skill + "']"));
            bool isSkillPresent = skillLabel.Text.Equals(skill);
            return isSkillPresent;

        }

        //validate skill Level is added
        public bool ValidateSkillLevelIsAdded(string skillLevel)
        {
            IWebElement skillLevelLabel = Driver.FindElement(By.XPath("//td[normalize-space()='" + skillLevel + "']"));
            bool isSkillLevelPresent = skillLevelLabel.Text.Equals(skillLevel);
            return isSkillLevelPresent;
        }

        public void ClickOnEducationTab()
        {
            Educationtab.Click();
        }

        public void ClickOnAddNewButtonOfEducationTab()
        {
            addnewOfEducationTab.Click();
            
        }

        public void ClickOnADDButton()
        {
            Add.Click();
            wait(500);
        }

        public bool validatecollegename(string CollegeName)

        {
            IWebElement CollegeNamevalidation = Driver.FindElement(By.XPath("//td[normalize-space()='" + CollegeName + "']"));
            bool isCollegeName = CollegeNamevalidation.Text.Equals(CollegeName);
            return isCollegeName;

        }

        public bool validatecountryofcollege(string Countryofcollege)

        {
            IWebElement CountryofCollegevalidation = Driver.FindElement(By.XPath("//td[normalize-space()='" + Countryofcollege + "']"));
            bool iscountryofcollege = CountryofCollegevalidation.Text.Equals(Countryofcollege);
            return iscountryofcollege;

        }

        public bool validatetitle(string Title)

        {
            IWebElement titlevalidation = Driver.FindElement(By.XPath("//td[normalize-space()='" + Title + "']"));
            bool istitle = titlevalidation.Text.Equals(Title);
            return istitle;

        }
        public bool validatedegree(string Degree)

        {
            IWebElement Degreevalidation = Driver.FindElement(By.XPath("//td[normalize-space()='" + Degree + "']"));
            bool isDegree = Degreevalidation.Text.Equals(Degree);
            return isDegree;

        }
        public bool validategraduationyear(string Yearofgraduation)

        {
            IWebElement Graduationyearvalidation = Driver.FindElement(By.XPath("//td[normalize-space()='" + Yearofgraduation + "']"));
            bool isGraduationyear = Graduationyearvalidation.Text.Equals(Yearofgraduation);
            return isGraduationyear;
        }

        public void ClickOnCertificationsTab()
        {
            ElementExists("XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 2);
            certificationTab.Click();

        }

        public void ClickOnAddNewButtonOfCertificationsTab()
        {
            addNewCertification.Click();
            
        }

        public void AddCertifications(String CertificateorAward, String CertfiedFrom, String Year)
        {
            certificateOrAward.SendKeys(CertificateorAward);
            certifiedfrom.SendKeys(CertfiedFrom);
            var yearOfCertificationDropDown = new SelectElement(yearOfCertificationDropdown);
            yearOfCertificationDropDown.SelectByText(Year);

        }

        public bool ValidateCertificateorAward(String CertificateorAward)
        {
            ElementExists("XPath", "//td[normalize-space()='Barch']", 4);
            bool isCertificateorAward = Certificateaddedvalidation.Text.Equals("Barch");
            return isCertificateorAward;
        }

        public bool ValidateCertifiedFrom(String CertfiedFrom)
        {
            bool isCertifiedFrom = Certifiedfromvalidation.Text.Equals("Adobe");
            return isCertifiedFrom;
        }

        public bool ValidateCertifiedyear(String Year)
        {
            bool isCertifiedYear = YearValidation.Text.Equals("2017");
            return isCertifiedYear;
        }

        public void ClickOnEditButtonNearDescriptionBox()
        {
            ElementExists("XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 5);
            Descriptionicon.Click();
        }

        public void EnterDescriptionInDescriptionBox()
        {

           Descriptionbox.Clear();

            Descriptionbox.SendKeys("Hi goodmorning there");
            wait(1000);
        }

        public void ClickOnSaveButton()
        {
            Descriptionsavebutton.Click();
            Thread.Sleep(1500);
        }

        public string ValidateThatDescriptionIsSaved()
        {
            string descriptiontext = Descriptionsuccess.Text;
            Console.WriteLine("Description text is " + descriptiontext);
            return descriptiontext;
        }

        public string ValidateDescriptionSuccessfullyEntered()
        {
            ElementExists("XPath", "//div[@class='ns-box-inner']", 3);
            string descriptiontext = Descriptionsuccess.Text;
            return descriptiontext;
        }

        public void ClickOnAvailabilityDropDownList()
        {
            //span[normalize-space()='Part Time']//i[@class='right floated outline small write icon']
            //ElementExists("XPath", "span[normalize-space()='Part Time']//i[@class='right floated outline small write icon']", 5);
            wait(4000);
            availabilityicon.Click();
        }


        public void SelectPartTimeFromAvailabiltyDropDownList()
        {
            var availabilityDropDownList = new SelectElement(availabilityelement);
            availabilityDropDownList.SelectByText("Part Time");
        }

        public bool ValidateAvailabilityDropDown()
        {
            bool isAvailabilityDropDownSelected = availabilityvalidationelement.Text.Equals("Part Time");
            return isAvailabilityDropDownSelected;
        }

        public void ClickOnHoursDropDown()
        {
            ElementExists("XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i", 5);
            Hoursediticon.Click();
        }
        public void SelectValueFromHoursDropDown()
        {
            var hoursDropDown = new SelectElement(Hourelement);
            hoursDropDown.SelectByText("Less than 30hours a week");
        }

        public bool ValidateHoursDropDown()
        {
            bool isHourSelected = hourvalidationelement.Text.Equals("Less than 30hours a week");
            return isHourSelected;
        }

        public void ClickOnEarnTargetIcon()
        {
          
            ElementExists("XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i", 5);
            Earntargeticon.Click();
        }

        public void SelectFromTargetDropDownList()
        {
            wait(1000);
            //Thread.Sleep(1000);
            var earnTargetDropDown = new SelectElement(EarnTargetelement);
            earnTargetDropDown.SelectByText("Less than $500 per month");
        }

        public bool ValidateTargetDropDownListSelected()
        {
            ElementExists("XPath", "//*[contains(text(),'Less than $500 per month')]", 5);
            bool isTargetDropDownValueSelected = Earntargetvalidationelement.Text.Equals("Less than $500 per month");
            return isTargetDropDownValueSelected;

        }

        public void ClickOnSearchskillsIcon()
        {
            ElementExists("XPath", "//div[@class='ui secondary menu']//i[@class='search link icon']", 7);
            searchicon.Click();
            wait(5000);

        }

        public void ClickOnGraphicsDesignCategoryUnderAllCategories()
        {
          
            ElementExists("XPath", "//a[contains(text(),'Graphics & Design')]", 7);
            GraphicsDesignLink.Click();
            wait(5000);
        }

        public void ClickOnImageOfTheDisplayedPerson()
        {
            ElementExists("XPath", "//p[normalize-space()='I design beautiful logos']", 5);
            searchedImage.Click();

        }

        public bool ValidateThatPersonIsUnderGraphicsDesignCategory()
        {

            ElementExists("XPath", "//a[contains(text(),'Graphics & Design')]", 5);

            bool isGraphicsandDesignDisplayed = GraphicsDesign.Displayed;
            return isGraphicsandDesignDisplayed;

        }
        public bool ThenIValidateThatPersonIsUnderLogoDesignSubCategory()
        {
          
            ElementExists("LinkText", "Logo Design", 7);
            bool isLogoDesigndisplayed = LogoDesign.Displayed;
            return isLogoDesigndisplayed;
        }
        public void ClickOnLogoDesignSubCategoryUnderGraphicsDesign()
        {
            ElementExists("XPath", "//div[@class='ui container']//div[@class='row-padded']//a[3]", 7);
            LogoDesignLink.Click();
        }

        public void ClickOnOnlineUnderFilter()
        {
            onlinefilter.Click();
        }
        public void ClickOnChat()
        {

            ElementExists("XPath", "//a[normalize-space()='Chat']", 3);
            Chat.Click();

        }
        public bool ValidatePersonDisplayedUnderLocationTypeOnline()
        {
        
            IJavaScriptExecutor JS = (IJavaScriptExecutor)Driver;
            JS.ExecuteScript("arguments[0].scrollIntoView(true)", Online);
           
            bool isOnlineDisplayed = Online.Displayed;
            return isOnlineDisplayed;

        }
        public void TypeMessageInMessageBox()
        {
            messagebox.SendKeys("Hi interested in trading with you?");
        }

        public void WhenIClickOnSendButton()
        {
            SendMessage.Click();
            wait(7000);
        }

        public string validatechatmessage()
        {
            ElementExists("XPath","//div[20]//div[1]//div[1]//span[1]",5);
            string chatmessagetext = Messageboxmessage.Text;
            return chatmessagetext;
        }

        public void HoverOnManageRequestsAndClickOnReceivedRequests()
        {
           
            Actions action = new Actions(Driver);
            ElementExists("XPath", "/html/body/div[1]/div/section[1]/div/div[1]", 5);
            action.MoveToElement(Managerequest).Perform();
            Thread.Sleep(5000);
           // ElementExists("XPath","//a[normalize-space()='Received Requests']",7);
           // wait(5000);
            Receivedrequest.Click();
            

        }

        public void WhenISearchForAUser()
        {
            searchuser.SendKeys("blippi");
            wait(3000);
         
        }

        public void ClickOnDisplayedImage()
        {
            //ElementExists("XPath", "//a[@class='image']//img", 3);
            searchuserimage.Click();
            wait(4000);

        }

        public void WhenITypeMessageInRequestBox()
        {
            IJavaScriptExecutor JS = (IJavaScriptExecutor)Driver;
            ElementExists("XPath","//*[@id='service-detail-section']/div[2]/div/div[2]/div[2]/div[2]/div/div[2]/div/div[1]/textarea", 7);
            //JS.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            JS.ExecuteScript("arguments[0].scrollIntoView(true)", Requestmessengerbox);
            wait(5000);
           //Thread.Sleep(5000);
            Requestmessengerbox.SendKeys("I am interested in trading iiiing");
        }

        public void WhenIClickOnRequestButton()
        {
            Thread.Sleep(5000);
            // ElementExists("XPath", "//div[contains(@class,'button')]", 7);
            Requestbutton.Click();
        }

        public void WhenIClickOnYesFromAlertPopUp()
        {
            ElementExists("XPath", "//button[normalize-space()='Yes']", 3);
            yes.Click();
        }

        public string RequestIsSentMessage()
        {
            ElementExists("XPath", "//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']", 8);
            String text = RequestSentMessage.Text;
            wait(6000);
            return text;


        }
        public void HoverOnManageRequestsAndClickSendRequests()
        {
            
            Actions action = new Actions(Driver);
            ElementExists("XPath", "/html/body/div[1]/div/section[1]/div/div[1]", 5);
            action.MoveToElement(Managerequest).Perform();
            ElementExists("LinkText","Sent Requests",6);
            Sendrequests.Click();
            Thread.Sleep(3000);
           
        }
        public void SendRequestValidate()
        {
        
            int rowcount = rownumber.Count();
            Console.WriteLine(rowcount);

            int colcount = columnsnumber.Count();
            Console.WriteLine(colcount);
            for (int i = 1; i <= rowcount; i++)
            {
                for (int j = 1; j <= colcount; j++)
                {
                    Console.WriteLine(Driver.FindElement(By.XPath("/ html[1] / body[1] / div[1] / div[1] / div[1] / div[2] / div[1] / table[1] / tbody[1] / tr[" + i + "] / td[" + j + "]")).Text);


                }

            }

        }
            public void ReceivedRequestsvalidation()
            {
                
                ElementExists("XPath", "//tbody/tr[2]/td[8]/button[1]", 82);
                int rowcount = rownumber.Count();
                Console.WriteLine(rowcount);
                int colcount = columnsnumber.Count();
                Console.WriteLine(colcount);
                for (int i = 1; i <= rowcount; i++)
                {
                    for (int j = 1; j <= colcount; j++)
                    {
                        Console.WriteLine(Driver.FindElement(By.XPath("/ html[1] / body[1] / div[1] / div[1] / div[1] / div[2] / div[1] / table[1] / tbody[1] / tr[" + i + "] / td[" + j + "]")).Text);


                    }

                }
            }

        }


    }







        

