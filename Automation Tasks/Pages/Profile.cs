using Advanced_Task.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;


namespace Advanced_Task.Pages
{
    class Profile
    {

        public Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);

        }

        #region  Initialize Web Elements 
        [FindsBy(How = How.XPath, Using = "//strong[normalize-space()='Location']")]
        private IWebElement Location { get; set; }
        //avilability drop down full time
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
        private IWebElement languagelabel{ get; set; }
        //languagelevel
        [FindsBy(How = How.XPath, Using = "//td[normalize-space()='Basic']")]
        private IWebElement languagelevel { get; set; }
        //skills tab
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]")]
        private IWebElement skilltab { get; set; }
        //add button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui teal button']")]
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
        //Graduationyearvalidation
        [FindsBy(How = How.XPath, Using = "//td[normalize-space()='2009']")]
        private IWebElement Graduationyearvalidation { get; set; }
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
        private IWebElement certifiedfrom{ get; set; }
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
        private IWebElement YearValidation{ get; set; }
        //Hi peppa link
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/div[1]/div[2]/div/span/div/a[2]")]
        private IWebElement HiPeppa { get; set; }
        
        //allcategorieslink
        [FindsBy(How = How.XPath, Using = "//div[@class='ui secondary menu']//i[@class='search link icon']")]
        private IWebElement allcategories { get; set; }
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i")]
        private IWebElement Hoursediticon { get; set; }
        //Earntarget icon
        //[FindsBy(How = How.XPath, Using = "(//span/i[@class='right floated outline small write icon'])[3]")]
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[4]/div/span/i")]
        private IWebElement Earntargeticon { get; set; }
        //Availabilityicon
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
        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Less than $500 per month')]")]
        private IWebElement Earntargetvalidationelement { get; set; }
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
        #endregion

        public void AddDescription()
        {
          
            Global.GlobalDefinitions.ElementExists("XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i", 6);

            Descriptionicon.Click();

            Descriptionbox.Clear();
            
            Descriptionbox.SendKeys("Hi goodmorning");
            Thread.Sleep(500);

            Descriptionsavebutton.Click();

            Thread.Sleep(1000);

        }

        public bool ValidateDescriptionText()
        {
            Global.GlobalDefinitions.ElementExists("XPath", "//div[@class='ns-box-inner']", 4);
            bool isSuccessMessagePresent = Descriptionsuccess.Text.Equals("Description has been saved successfully");
            return isSuccessMessagePresent;
        }

        
        public bool validateADDLanguage()
        {
            bool islanguagepresent = languagelabel.Text.Equals("French");
            return islanguagepresent;
        }

        public void ADDLanguage()
        {
            addNewButtonOfLanguageTab.Click();
          
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            string AddLanguagenew = GlobalDefinitions.ExcelLib.ReadData(1, "Addlanguage");
            
            AddLanguage.SendKeys(AddLanguagenew);

            var selectelement = new SelectElement(Languagedropdown);
            string addLevel = GlobalDefinitions.ExcelLib.ReadData(1, "Level");
            selectelement.SelectByValue(addLevel);
            addLanguage.Click();

        }


        public bool validateADDLanguagelevel()

        {
            bool islanguagelevelpresent = languagelevel.Text.Equals("Basic");
            return islanguagelevelpresent;
        }

        public void ADDSkill()
        {
            Global.GlobalDefinitions.ElementExists("XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]", 3);
            skilltab.Click();
            addbutton.Click();
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            string Addskillnew = GlobalDefinitions.ExcelLib.ReadData(1, "Addskill");
            addskill.SendKeys(Addskillnew);
            var selectskill = new SelectElement(skilldropdown);
            string skilllevel = GlobalDefinitions.ExcelLib.ReadData(1, "Skilllevel");
            selectskill.SelectByValue(skilllevel);
            skilladd.Click();
        }

        public bool validateSkillisAdded()

        {
            bool isskilladded = skillabel.Text.Equals("Ruby");
            return isskilladded;
        }
        public bool validateSkilllevelisAdded()

        {
            bool iskillleveladded = skillevel.Text.Equals("Intermediate");
            return iskillleveladded;
        }

        public void AddEducation()
        {
            GlobalDefinitions.ElementExists("XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[3]", 3);
            Educationtab.Click();
            addnewOfEducationTab.Click();
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            string addCollege = GlobalDefinitions.ExcelLib.ReadData(1, "Addcollege");
            collegename.SendKeys(addCollege);

            var selectCountrydropdown = new SelectElement(collegecountrydropdown);
            string countryOfCollege = GlobalDefinitions.ExcelLib.ReadData(1, "Countryofcollege");
            selectCountrydropdown.SelectByText(countryOfCollege);

            var titleDropDowncollege = new SelectElement(titleDropdown);
            string title = GlobalDefinitions.ExcelLib.ReadData(1, "Title");
            titleDropDowncollege.SelectByText(title);

            string adddegree = GlobalDefinitions.ExcelLib.ReadData(1, "Degree");
            Degree.SendKeys(adddegree);

            var yearOfGraduation = new SelectElement(yearOfGraduationDropdown);
            string yearOfGraduationfromExcel = GlobalDefinitions.ExcelLib.ReadData(1, "YearofGraduation");
            yearOfGraduationDropdown.SendKeys(yearOfGraduationfromExcel);

            addEducation.Click();

        }

        public bool validatecollegename()

        {
            bool iscollegename = collegenamevalidation.Text.Equals("Dublin university");
            return iscollegename;
        }

        public bool validatecountryofcollege()

        {
            
            bool iscountryofcollege = countryofcollegevalidation.Text.Equals("Ireland");
            return iscountryofcollege;
        }

        public bool validatetitle()

        {
           
            bool isTitle = titlevalidation.Text.Equals("Associate");
            return isTitle;
        }
        public bool validatedegree()

        {
            bool isDegree= Degreeevalidation.Text.Equals("VLSI");
            return isDegree;
        }
        public bool validategraduationyear()

        {
            bool isGraduationyear = Graduationyearvalidation.Text.Equals("2009");
            return isGraduationyear;
        }
        public void AddCertification()
        {
            Global.GlobalDefinitions.ElementExists("XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]", 3);
            certificationTab.Click();
            addNewCertification.Click();
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            string addCertificateoraward = GlobalDefinitions.ExcelLib.ReadData(1, "CertificateorAward");
            certificateOrAward.SendKeys(addCertificateoraward);
            string certifiedFrom = GlobalDefinitions.ExcelLib.ReadData(1, "Certifiedfrom");
            certifiedfrom.SendKeys(certifiedFrom);

            var yearofcertification = new SelectElement(yearOfCertificationDropdown);
            string addyear = GlobalDefinitions.ExcelLib.ReadData(1, "Year");
            yearOfCertificationDropdown.SendKeys(addyear);
            Global.GlobalDefinitions.ElementExists("XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]", 2);
            addcertification.Click();
            Thread.Sleep(2000);
        }

        public bool validateCertificate()
        {
            bool iscertificateadded = Certificateaddedvalidation.Text.Equals("Barch");
            return iscertificateadded;

        }
        public bool validateCertifiedfrom()
        {
            bool iscertifiedfrom = Certifiedfromvalidation.Text.Equals("Adobe");
            return iscertifiedfrom;

        }
        public bool validateCertifiedyear()
        {
           
            bool isGraduationyear =YearValidation.Text.Equals("2017");
            return isGraduationyear;

        }

      
        public void Hours()
        {
            Global.GlobalDefinitions.ElementExists("XPath", "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[3]/div/span/i", 5);
            Hoursediticon.Click();
           Global.GlobalDefinitions.ElementExists("XPath", "//select[@name='availabiltyHour']", 4);
            var hourdropdown = new SelectElement(Hourelement);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            string hourdropdownvalue = GlobalDefinitions.ExcelLib.ReadData(1, "Hours");
            hourdropdown.SelectByText(hourdropdownvalue);
        }

        

        public bool validateHours()

        {
            bool hourdropdownselected = hourvalidationelement.Text.Equals("Less than 30hours a week");
            return hourdropdownselected;
        }

        public string EarnTarget()
        {
            Earntargeticon.Click();
            var EarnTargetdropdown = new SelectElement(EarnTargetelement);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            string Earntargetdropdownvalue = GlobalDefinitions.ExcelLib.ReadData(1, "Earn Target");
            EarnTargetdropdown.SelectByText(Earntargetdropdownvalue);
            return Earntargetdropdownvalue; 
            
        }

        public bool validateEarnTarget()

        {
            bool isEarnTargetdropdownselected = Earntargetvalidationelement.Text.Equals("Less than $500 per month");
            return isEarnTargetdropdownselected;
         

        }

        public void  AvailabilityType()
        {
           Global.GlobalDefinitions.ElementExists("XPath", "(//span/i[@class='right floated outline small write icon'])[1]", 3);
            availabilityicon.Click();
            var availabilitydropdown = new SelectElement(availabilityelement);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            string availabilitydropdownvalue = GlobalDefinitions.ExcelLib.ReadData(1, "Availability");
            availabilitydropdown.SelectByText(availabilitydropdownvalue);

        }

        public bool validateAvailabilityType()
        {
           
            bool isavailabilitydropdownselected = availabilityvalidationelement.Text.Equals("Part Time");
             return isavailabilitydropdownselected;
         
        }

        public string LoggedinSuccessfully()
        {
            string actualTitle = GlobalDefinitions.driver.Title;
            return actualTitle;
            
        }



    }
}










    





