using Advanced_Task.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Advanced_Task.Pages
{
    class Commonelementsonscreen
    {

        public Commonelementsonscreen()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        #region  Initialize Web Elements 
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Chat']")]
        private OpenQA.Selenium.IWebElement Chat { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='chatTextBox']")]
        private OpenQA.Selenium.IWebElement messagebox { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[10]//div[1]//div[1]")]
        private IWebElement Messageboxmessage { get; set; }
        [FindsBy(How = How.XPath, Using = "//button[@id='btnSend']")]
        private IWebElement Sendchat { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[text()='Notification']")]
        private IWebElement notification { get; set; }
        //see all
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='See All...']")]
        private IWebElement Seeall { get; set; }
        //Deleteicon
        [FindsBy(How = How.XPath, Using = "//i[@class='trash icon']")]
        private IWebElement Deleteicon { get; set; }
        //checkbox
        [FindsBy(How = How.XPath, Using = "//input[@value='0']")]
        private IWebElement Checkbox { get; set; }
        //DeleteSuccessmessage
        [FindsBy(How = How.XPath, Using = "//div[@class='ns-box-inner']")]
        private IWebElement DeleteSuccessmessage { get; set; }
        //Notification mark as read
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Mark all as read']")]
        private IWebElement notificationmarkasread { get; set; }
        //Notificationbluelabel
        [FindsBy(How = How.XPath, Using = "//div[@class='floating ui blue label']")]
        private IWebElement notificationbluelabel { get; set; }
        //[FindsBy(How = How.LinkText, Using = "Load More")]
        //[FindsBy(How = How.XPath, Using = "//*[@id='notification-section']/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a")]
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a")]
        private IWebElement Loadmore { get; set; }
        //show less
        //[FindsBy(How = How.LinkText, Using = "Show Less")]
        //[FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[7]/div[1]/center/a")]
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='...Show Less']")]
        private IWebElement Showlessnotification { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Go to page')]")]
        private IList<IWebElement> Gotopage { get; set; }
        //selectallicon
        [FindsBy(How = How.XPath, Using = "//i[@class='mouse pointer icon']")]
        private IWebElement selectallicon { get; set; }
        //unselectallicon
        [FindsBy(How = How.XPath, Using = "//i[@class='ban icon']")]
        private IWebElement unselectallicon { get; set; }
        //checkboxicon
        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox']")]
        private IWebElement checkboxicon { get; set; }
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
        //onlinefilter
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Online']")]
        private IWebElement onlinefilter { get; set; }
        //onlinefiltervalidation
        [FindsBy(How = How.XPath, Using = "//div[normalize-space()='Online']")]
        private IWebElement onlinefiltervalidation { get; set; }
        //onsitefilter
        [FindsBy(How = How.XPath, Using = "//button[normalize-space()='Onsite']")]
        private IWebElement onsitefilter { get; set; }
        //searchimage
        [FindsBy(How = How.XPath, Using = "//p[normalize-space()='I design beautiful logos']")]
        private IWebElement searchimage { get; set; }
        //Unhighlightedelement
        [FindsBy(How = How.XPath, Using = "//*[@id='notification - section']/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[2]/div[1]/a/div[1]")]
        private IWebElement Unhighlightedelement { get; set; }
        //Highlightedelement
        //[FindsBy(How = How.XPath, Using = "//*[@id='notification - section']/div[2]/div/div/div[3]/div[2]/span/span/div/div[1]/div/div/div[2]/div[1]/a/div[1]")]
        [FindsBy(How = How.XPath, Using = "//div[@name='63eec853cadfd90001fdfed2']//div[@class='ui grid']//div[@class='content'][normalize-space()='You have Pending trade request from BlippiRoy.']")]
        private IWebElement Highlightedelement { get; set; }
        //Markasreadicon
        [FindsBy(How = How.XPath, Using = "//i[@class='check square icon']")]
        private IWebElement Markasreadicon { get; set; }
        //ListOfCheckBoxes
        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox']")]
        private IList<IWebElement> ListOfCheckBoxes { get; set; }

        #endregion

        public void chatting()
        {
            Global.GlobalDefinitions.ElementExists("XPath", "//a[normalize-space()='Chat']", 3);
            Chat.Click();
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Commonelementsonscreen");
            string chats = GlobalDefinitions.ExcelLib.ReadData(1, "Chatmessages");
            messagebox.SendKeys(chats);
            // Thread.Sleep(1000);
            Global.GlobalDefinitions.wait(1000);
            Sendchat.Click();
        }

        public string validatechatmessage()
        {
            //Global.GlobalDefinitions.ElementExists("XPath", "//*[@id='right']/div/span", 6);
            Global.GlobalDefinitions.ElementExists("XPath", "//div[10]//div[1]//div[1]", 6);
            string chatmessagetext = Messageboxmessage.Text;
            return chatmessagetext;
        }

        public string ChatHistory()
        {
            Global.GlobalDefinitions.ElementExists("XPath", "//a[normalize-space()='Chat']", 3);
            Chat.Click();
            Global.GlobalDefinitions.ElementExists("XPath", "//*[@id='chatBox']/div[18]", 4);
            string chatmessagetext = Messageboxmessage.Text;
            return chatmessagetext;
        }

        public void DeleteNotifications()
        {
            Actions action = new Actions(Global.GlobalDefinitions.driver);
            Global.GlobalDefinitions.ElementExists("XPath", "//div[text()='Notification']", 5);
            action.MoveToElement(notification).Perform();
            Global.GlobalDefinitions.ElementExists("XPath", "//a[normalize-space()='See All...']", 5);
            Seeall.Click();

            Global.GlobalDefinitions.ElementExists("XPath", "//input[@value='0']", 5);
            Checkbox.Click();
            Global.GlobalDefinitions.wait(1000);
            Deleteicon.Click();

        }


        public string ValidateDeleteNotification()

        {
            Global.GlobalDefinitions.ElementExists("XPath", "//div[@class='ns-box-inner']", 6);
            String successmessage = DeleteSuccessmessage.Text;
            return successmessage;
        }


        public void NotificationsMarkasReadSecond()
        {
            Actions action = new Actions(Global.GlobalDefinitions.driver);
            Global.GlobalDefinitions.ElementExists("XPath", "//div[text()='Notification']", 4);
            action.MoveToElement(notification).Perform();
            Global.GlobalDefinitions.ElementExists("XPath", "//a[normalize-space()='See All...']", 8);
            Seeall.Click();
            Global.GlobalDefinitions.wait(5000);

            Global.GlobalDefinitions.ElementExists("XPath", "//input[@value='0']", 6);
            Checkbox.Click();
            Markasreadicon.Click();
           
        }

        public string ValidateNotificationsMarkasRead()
        {
           Global.GlobalDefinitions.ElementExists("XPath","//div[@name='63eec853cadfd90001fdfed2']//div[@class='ui grid']//div[@class='content'][normalize-space()='You have Pending trade request from BlippiRoy.']", 5);
            string highLightedtext = Highlightedelement.GetCssValue("font-weight");
            return highLightedtext;

        }

        public void ShowLess()
        {
            Actions action = new Actions(Global.GlobalDefinitions.driver);
            Global.GlobalDefinitions.ElementExists("XPath", "//div[text()='Notification']", 5);
            action.MoveToElement(notification).Perform();
            Global.GlobalDefinitions.ElementExists("XPath", "//a[normalize-space()='See All...']", 5);
            Seeall.Click();
            IJavaScriptExecutor JS = (IJavaScriptExecutor)Global.GlobalDefinitions.driver;
            JS.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Global.GlobalDefinitions.ElementExists("XPath", "/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a", 5);
            Loadmore.Click();
            IJavaScriptExecutor JS1 = (IJavaScriptExecutor)Global.GlobalDefinitions.driver;
            JS1.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            Global.GlobalDefinitions.ElementExists("XPath", "//a[normalize-space()='...Show Less']", 4);
            Showlessnotification.Click();
        }



        public void Loadmorenotification()
        {
            Actions action = new Actions(Global.GlobalDefinitions.driver);
            Global.GlobalDefinitions.ElementExists("XPath", "//div[text()='Notification']", 3);
            action.MoveToElement(notification).Perform();
            Global.GlobalDefinitions.ElementExists("XPath", "//a[normalize-space()='See All...']", 3);
            Seeall.Click();
            Global.GlobalDefinitions.ElementExists("XPath", "/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a", 5);
            Loadmore.Click();
            Global.GlobalDefinitions.wait(5000);
            
        }


        public void SelectAll()
        {
            Actions action = new Actions(Global.GlobalDefinitions.driver);
            Global.GlobalDefinitions.ElementExists("XPath", "//div[text()='Notification']", 3);
            action.MoveToElement(notification).Perform();
            Global.GlobalDefinitions.ElementExists("XPath", "//a[normalize-space()='See All...']", 3);
            Seeall.Click();
            Global.GlobalDefinitions.ElementExists("XPath", "/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a", 5);
            selectallicon.Click();
            Global.GlobalDefinitions.wait(3000);
        }

        public bool SelectAllvalidation()
        {
            Global.GlobalDefinitions.ElementExists("XPath", "//input[@type='checkbox']", 5);
            bool ischeckboxselected = checkboxicon.Selected;
            return ischeckboxselected;
        }

        public void UnSelectAll()
        {
            Actions action = new Actions(Global.GlobalDefinitions.driver);
            Global.GlobalDefinitions.ElementExists("XPath", "//div[text()='Notification']", 3);
            action.MoveToElement(notification).Perform();
            Global.GlobalDefinitions.ElementExists("XPath", "//a[normalize-space()='See All...']", 3);
            Seeall.Click();
            Global.GlobalDefinitions.ElementExists("XPath", "/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a", 5);
            Loadmore.Click();
            selectallicon.Click();
            Thread.Sleep(1000);
            unselectallicon.Click();
        }


        public bool UnSelectAllvalidation()
        {
            Global.GlobalDefinitions.ElementExists("XPath", "//input[@type='checkbox']", 5);
            bool ischeckboxselected = checkboxicon.Selected;
            return ischeckboxselected;
        }

        public void searchskillsbycategory()
        {

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            string categorytoselect = GlobalDefinitions.ExcelLib.ReadData(1, "Categories");
            Searchskilltextbox.SendKeys(categorytoselect);
            searchicon.Click();

        }

        public bool searchskillsbycategoryvalidation()
        {

            bool iscategorygraphicsadded = categoryvalidation.Text.Equals("Graphics");
            return iscategorygraphicsadded;
        }

        public void searchskillsbysubcategory()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            string subcategorytoselect = GlobalDefinitions.ExcelLib.ReadData(1, "SubCategories");
            Searchskilltextbox.SendKeys(subcategorytoselect);
            searchicon.Click();
            Global.GlobalDefinitions.ElementExists("XPath", "//p[normalize-space()='Logo Design']", 4);

        }
        public bool searchskillsbysubcategoryvalidation()
        {
            bool issubcategoryadded = subcategoryvalidation.Text.Equals("Logo Design");
            return issubcategoryadded;
        }

        public void filter()
        {
            searchicon.Click();
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
            string filter = GlobalDefinitions.ExcelLib.ReadData(1, "Filter");
            if (filter == "Online")
            {
                onlinefilter.Click();
            }
            else
            {
                onsitefilter.Click();
            }


        }

        public bool Validateonlinefilter()
        {
            Global.GlobalDefinitions.ElementExists("XPath", "//p[normalize-space()='I design beautiful logos']", 6);
            searchimage.Click();
            bool isonlinefilterdisplayed = onlinefiltervalidation.Text.Equals("Online");
            return isonlinefilterdisplayed;
        }

        public bool ValidateShowLess()
        {

            int checkboxcount = ListOfCheckBoxes.Count;


            if (checkboxcount <= 5)
            {
                Console.WriteLine("showless not displayed");
                return true;
            }
            else
            {
                Console.WriteLine("showless displayed");
                return false;
            }

        }

        public bool ValidateLoadMore()
        {
            Global.GlobalDefinitions.ElementExists("XPath", "//input[@type='checkbox']", 3);
            int t = ListOfCheckBoxes.Count;
            Console.WriteLine("List of checkboxes number is......." + t);
            if (t >= 5)
            {
                Console.WriteLine("Loadmore is displayed");
                return true;
            }
            else
            {
                Console.WriteLine("Loadmore is not displayed");
                return false;


            }
        }
    }
}
    
