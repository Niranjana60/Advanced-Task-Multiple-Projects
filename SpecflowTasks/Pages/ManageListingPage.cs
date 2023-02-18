
using Advanced_task__test_project.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Advanced_task__test_project.Pages
{
    public class ManageListingPage:BasePage
    {
        
        public ManageListingPage(IWebDriver driver):base(driver)
        {
           

        }

        #region  Initialize Web Elements
        //Click on Manage Listings Link
        //[FindsBy(How = How.XPath, Using = "//a[normalize-space()='Manage Listings']")]

        //[FindsBy(How = How.CssSelector, Using = "body > div:nth-child(1) > div:nth-child(1) > section:nth-child(2) > div:nth-child(1) > a:nth-child(3)")]
        // [FindsBy(How = How.LinkText, Using = "Manage Listings")]

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Listings')]")]
        private IWebElement ManageListingsLink { get; set; }
        //Edit the listing
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i")]
        private IWebElement Editicon { get; set; }

        //Title
        [FindsBy(How = How.Name, Using = "title")]
        private IWebElement Title { get; set; }

        //save
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }
        //input[@value='Save']

        //Deleteicon
        //[FindsBy(How = How.XPath, Using = "//tbody/tr[4]/td[8]/div[1]/button[3]/i[1]")]
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i")]
        private IWebElement Deleteicon { get; set; }

        //yesicon
        //[FindsBy(How = How.Name, Using = "//button[normalize-space()='Yes']")]
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div[3]/button[2]")]

        private IWebElement yesicon { get; set; }

        //Delete success message
        [FindsBy(How = How.XPath, Using = "//div[@class='ns-box-inner']")]
        private IWebElement Deletemessage { get; set; }

        //Title editted
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]")]
        private IWebElement Titleeditted { get; set; }
        //TitleValue
        [FindsBy(How = How.XPath, Using = "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]")]
        private IWebElement Titlevalue { get; set; }

        #endregion

        public void NavigateToListingManagementPage(string url)
        {
            Driver.Navigate().GoToUrl("http://192.168.99.100:5000/Home/ListingManagement");
            wait(4000);
        }

        public void ClickOnManageListings()
        {
            //Thread.Sleep(5000);

            //ElementExists("LinkText", "Manage Listings", 2);
            // Global.GlobalDefinitions.ElementExists("XPath", "//a[normalize-space()='Manage Listings']", 5);
          ElementExists("XPath","//a[contains(text(),'Manage Listings')]",5);
            ManageListingsLink.Click();
            wait(4000);

        }

        public string NavigatedToListingManagementPageforValidation()
        {
            string title = Driver.Title;
            return title;
        }

        public void ClickOnEditIconFromManageListing()
        {
            //Thread.Sleep(6000);
            ElementExists("XPath","//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i",7);
            Editicon.Click();

        }
        public void EditDetailsInTitleTextBox()
        {
            ElementExists("Name", "title", 6);
            //Thread.Sleep(5000);
            Title.Clear();
            Title.SendKeys("I provide writing scripts");
            //Thread.Sleep(5000);
            IJavaScriptExecutor JS = (IJavaScriptExecutor)base.Driver;
            JS.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
        }

        public void SaveEdittedTitle()
        {
            Save.Click();
        }

        public string ValidateEdittedDetailsIsSaved()
        {
           // ManageListingsLink.Click();
            ElementExists("XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]",8);
            string title = Titleeditted.Text;
            return title;
        }

        public string NavigatedToServiceLisingPage()
        {
            string titleofServiceListingPage = Driver.Title;
            return titleofServiceListingPage;

        }

        //public void DeleteManageListings()
        //{
        //    ManageListingsLink.Click();
        //    ElementExists("XPath", "//tbody/tr[1]/td[8]/div[1]/button[3]/i[1]", 5);
        //    Deleteicon.Click();
            
        //}

        public void ClickOnDeleteIcon()
        {
            //Thread.Sleep(5000);
            // ElementExists("XPath","//tbody/tr[1]/td[8]/div[1]/button[3]/i[1]",5);
            ElementExists("XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[3]/i", 5);
            Deleteicon.Click();
            
        }

        public void ClickOnYes()
        {

            ElementExists("XPath", "/html/body/div[2]/div/div[3]/button[2]", 3);
            yesicon.Click();

        }

        public bool ValidateDeleteManageListings()
        {

            ElementExists("XPath", "//div[@class='ns-box-inner']", 7);

            bool deleteMessageTest = Deletemessage.Text.EndsWith("has been deleted");
            //Thread.Sleep(5000);
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + deleteMessageTest);
            return deleteMessageTest;
        }

        public string ValidateSaveSkills()
        {
            //ElementExists("XPath","//div[@class='ns-box-inner']", 7);
            //String saveSuccessText = SaveSuccess.Text;
            Thread.Sleep(5000);
            // Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + saveSuccessText);
            //return saveSuccessText;
            //return SaveSuccess.Text == "Service Listing Added Successfully";
            String titletext = Titlevalue.Text;
            return titletext;


        }

    }
}

