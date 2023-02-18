using Advanced_Task.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Advanced_Task.Pages
{
    class Managelisting
    {
        public Managelisting()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);

        }

        #region  Initialize Web Elements 

        //Click on Manage Listings Link
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
        //Deleteicon
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/div[1]/button[3]/i[1]")]
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


        public void EditManageListings()
        {
            Global.GlobalDefinitions.ElementExists("XPath","//a[contains(text(),'Manage Listings')]",5);
            ManageListingsLink.Click();
            Global.GlobalDefinitions.ElementExists("XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[8]/div/button[2]/i",7);
            Editicon.Click();
           Global.GlobalDefinitions.ElementExists("Name", "title", 6);
            Title.Clear();
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");
            string titleEditted = GlobalDefinitions.ExcelLib.ReadData(1, "Edittedtitle");
            Title.SendKeys(titleEditted);
            IJavaScriptExecutor JS =(IJavaScriptExecutor)Global.GlobalDefinitions.driver;
            JS.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Save.Click();
            Thread.Sleep(3000);
        }

        public string validateeditManageListings()
        {
            Global.GlobalDefinitions.ElementExists("XPath", "//a[contains(text(),'Manage Listings')]", 5);
            ManageListingsLink.Click();
            Global.GlobalDefinitions.ElementExists("XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]", 4);
            string title= Titleeditted.Text;
            return title;
        }

        public void DeleteManageListings()
        {
            Global.GlobalDefinitions.ElementExists("XPath", "//a[contains(text(),'Manage Listings')]", 5);
            ManageListingsLink.Click();
            Global.GlobalDefinitions.ElementExists("XPath","//tbody/tr[1]/td[8]/div[1]/button[3]/i[1]", 5);
            Deleteicon.Click();
            Global.GlobalDefinitions.ElementExists("XPath", "/html/body/div[2]/div/div[3]/button[2]", 3);
            yesicon.Click();
        }

        public bool ValidateDeleteManageListings()
        {
           
            Global.GlobalDefinitions.ElementExists("XPath", "//div[@class='ns-box-inner']",3);

            bool deleteMessageTest = Deletemessage.Text.EndsWith("has been deleted");
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + deleteMessageTest);
            return deleteMessageTest;
        }

        public string ValidateSaveSkills()
        {
            Global.GlobalDefinitions.ElementExists("XPath", "//*[@id='listing-management-section']/div[2]/div[1]/div[1]/table/tbody/tr[1]/td[3]",8);
            String titletext = Titlevalue.Text;
            return titletext;

        }




    }
}
