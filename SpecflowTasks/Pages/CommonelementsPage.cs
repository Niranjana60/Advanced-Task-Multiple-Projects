
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Advanced_task__test_project.Pages
{
    public class CommonElementsPage : BasePage
    {
        public CommonElementsPage(IWebDriver driver) : base(driver)
        {

        }
        #region  Initialize Web Elements

        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Chat']")]
        private IWebElement Chat { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='chatTextBox']")]
        private IWebElement messagebox { get; set; }

        
        [FindsBy(How = How.XPath, Using = "//div[20]//div[1]//div[1]//span[1]")]
        private IWebElement Messageboxmessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@id='btnSend']")]
        private IWebElement Send { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[text()='Notification']")]
        private IWebElement notification { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='floating ui blue label']")]
        private IWebElement notificationbluelabel { get; set; }
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
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Mark all as read')]")]
        private IWebElement notificationmarkasread { get; set; }
        //Notificationbluelabel
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a")]
        private IWebElement Loadmore { get; set; }
        //show less
        //[FindsBy(How = How.LinkText, Using = "Show Less")]
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='...Show Less']")]
        //[FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[2]/div[1]/div[1]/div[3]/div[2]/span[1]/span[1]/div[1]/div[8]/div[1]/center[1]/a[1]")]
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
        private IWebElement searchicontwo { get; set; }
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
        private IWebElement searchedImagetwo { get; set; }
        //searchimage
        [FindsBy(How = How.LinkText, Using = "Logo Design")]
        private IWebElement LogoDesign { get; set; }
        //[FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.ui.grid.service-details div.row:nth-child(1) div.content div.header-bottom.cf div.ui.breadcrumb > a.section:nth-child(3)")]
        [FindsBy(How = How.LinkText, Using = "Graphics & Design")]
        private IWebElement GraphicsDesign { get; set; }
        //[FindsBy(How = How.XPath, Using = "//a[contains(text(),'Graphics & Design')]")]
        //[FindsBy(How = How.XPath, Using = "//b[normalize-space()='Graphics & Design']")]
        //[FindsBy(How = How.XPath, Using = "//*[@id='service-search-section']/div[2]/div/section/div/div[1]/div[1]/div/a[2]/text()")]
        //[FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/section/div/div[1]/div[1]/div/a[2]/text()")]
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Graphics & Design')]")]
        private IWebElement GraphicsDesignLink { get; set; }
        // [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Logo Design')]")]
        //[FindsBy(How = How.XPath, Using = "/html/body/div/div/div/div[2]/div/section/div/div[1]/div[1]/div/a[3]/text()")]
        [FindsBy(How = How.XPath, Using = "//div[@class='ui container']//div[@class='row-padded']//a[3]")]
        private IWebElement LogoDesignLink { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Online')]")]
        private IWebElement Online { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@type='checkbox']")]
        private IList<IWebElement> ListOfCheckBoxes { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@value='0']")]
        private IWebElement CheckboxofDeleteIcon { get; set; }
        //checkbox near Notification
        [FindsBy(How = How.XPath, Using = "//input[@value='0']")]
        private IWebElement CheckboxiconnearNotification { get; set; }
        //Notification messagebox
        [FindsBy(How = How.XPath, Using = "//div[@class='ns-box-inner']")]
        private IWebElement NotificationMessage { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@data-tooltip='Mark selection as read']")]
        private IWebElement MarkAsReadIcon { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@name='63efbefcbb8b270001f5777f']//div[@class='ui grid']//div[@id='myDIV']")]
        private IWebElement Highlightedelement { get; set; }

        #endregion

        public void NavigateToUrl(string url)
        {
            Driver.Navigate().GoToUrl("http://192.168.99.100:5000");
        }

        public void HoverOnNotificationsandClickOnMarkAllAsRead()
        {
            Actions action = new Actions(Driver);
            ElementExists("XPath", "//div[text()='Notification']", 4);
            action.MoveToElement(notification).Perform();
            ElementExists("XPath", "//a[contains(text(),'Mark all as read')]", 4);
            notificationmarkasread.Click();

        }

        public void ClickOnCheckboxAgainstTheDeleteNotification()
        {
            ElementExists("XPath", "//input[@value='0']", 4);
            Checkbox.Click();

        }

        public void ClickOnDeleteIcon()
        {
            Deleteicon.Click();
        }

        public string ValidateThatNotificationIsDeleted()
        {
            ElementExists("XPath", "//div[@class='ns-box-inner']", 5);
            string successmessage = DeleteSuccessmessage.Text;

            return successmessage;
        }

        public bool ViewTheNotificationNumberOnMarkAsAllRead()
        {
            ElementExists("XPath", "//div[@class='floating ui blue label']", 7);
            bool notificationnumber = notificationbluelabel.Text.Contains("2");
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + notificationnumber);
            return notificationnumber;
        }

        public void ClickOnMarkAsRead()
        {
            
            ElementExists("XPath", "//a[normalize-space()='Mark all as read']", 4);
            MarkAsReadIcon.Click();
           
        }

        public bool ValidateMarkAllAsRead()
        {
            
            ElementExists("XPath", "//div[@class='floating ui blue label']", 7);
            bool text = notificationbluelabel.Displayed;
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + text);
            return text;


        }


        public void ClickOnSearchskillsIcontwo()
        {
            ElementExists("XPath", "//div[@class='ui secondary menu']//i[@class='search link icon']", 5);
            searchicontwo.Click();
            //wait(7000);
            Thread.Sleep(7000);

        }

        public bool NotificationNumberWillNotBeDisplayed()
        {
            ElementExists("XPath", "//div[@class='floating ui blue label']", 7);
            bool text = notificationbluelabel.Displayed; ;
            Console.WriteLine("AAAAAAAAAAAAAAAAAA************************" + text);
            return text;
        }


        public void ClickOnLoadMore()
        {
            ElementExists("XPath", "/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a", 7);
            Loadmore.Click();
        }

        public void ClickOnSelectAll()
        {
            selectallicon.Click();
        }


        public bool ValidateSelectAll()
        {
            ElementExists("XPath", "//input[@type='checkbox']", 5);
            bool ischeckboxselected = checkboxicon.Selected;
            return ischeckboxselected;
        }

        public void HoverOnNotificationsAndClickSeeAll()
        {
            Actions action = new Actions(Driver);
            ElementExists("XPath", "//div[text()='Notification']", 6);
            action.MoveToElement(notification).Perform();
            ElementExists("XPath", "//a[normalize-space()='See All...']", 7);
            Seeall.Click();

        }

        public void ShowLess()
        {
            Actions action = new Actions(Driver);
            ElementExists("XPath", "//div[text()='Notification']", 8);
            action.MoveToElement(notification).Perform();
            ElementExists("XPath", "//a[normalize-space()='See All...']", 8);
            Seeall.Click();
            IJavaScriptExecutor JS = (IJavaScriptExecutor)base.Driver;
            JS.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            ElementExists("XPath", "/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a", 9);
            Loadmore.Click();
            wait(3000);
            IJavaScriptExecutor JS1 = (IJavaScriptExecutor)Driver;
            JS1.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            ElementExists("XPath", "//a[normalize-space()='...Show Less']", 9);
            Showlessnotification.Click();
            wait(5000);
        }


        public bool ValidateShowLess()
        {

            int checkboxcount = ListOfCheckBoxes.Count;
           

            if (checkboxcount <= 5)
            {
                Console.WriteLine("showless not displayed");
                return true;
            } else
            {
                Console.WriteLine("showless displayed");
                return false;
            }

        }
        public void Loadmorenotification()
        {
            Actions action = new Actions(Driver);
            ElementExists("XPath", "//div[text()='Notification']", 7);
            action.MoveToElement(notification).Perform();
            ElementExists("XPath", "//a[normalize-space()='See All...']", 8);
            Seeall.Click();
            IJavaScriptExecutor JS = (IJavaScriptExecutor)base.Driver;
            JS.ExecuteScript("window.scrollTo(0, document.body.scrollHeight)");
            ElementExists("XPath", "/html/body/div[1]/div[2]/div/div/div[3]/div[2]/span/span/div/div[6]/div/center/a", 7);
            Loadmore.Click();
        }

        public bool ValidateLoadMore()
        {
            ElementExists("XPath", "//input[@type='checkbox']", 3);
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
        public void DeleteNotifications()
        {
            Actions action = new Actions(Driver);
            ElementExists("XPath", "//div[text()='Notification']", 5);
            action.MoveToElement(notification).Perform();
            ElementExists("XPath", "//a[normalize-space()='See All...']", 4);
            Seeall.Click();
            ElementExists("XPath", "//input[@value='0']", 5);
            CheckboxofDeleteIcon.Click();
           // wait(1000);
            Thread.Sleep(1000);
            Deleteicon.Click();

        }
        public string ValidateDeleteNotification()

        {

            ElementExists("XPath", "//div[@class='ns-box-inner']", 7);
            string successmessage = DeleteSuccessmessage.Text;
            //wait(5000);
            Thread.Sleep(5000);
            return successmessage;
        }
        public void SelectAll()
        {
            Actions action = new Actions(Driver);
            ElementExists("XPath", "//div[text()='Notification']", 5);
            action.MoveToElement(notification).Perform();
             ElementExists("XPath","//a[normalize-space()='See All...']", 4);
            Seeall.Click();
            Thread.Sleep(7000);
            // ElementExists("XPath", "//i[@class='mouse pointer icon']",6);
            selectallicon.Click();
            wait(5000);
            //Thread.Sleep(5000);

        }
        public bool SelectAllvalidation()
        {
            ElementExists("XPath","//input[@type='checkbox']",5);
            bool ischeckboxselected = checkboxicon.Selected;
            return ischeckboxselected;

        }
        public void UnSelectAll()
        {

            ElementExists("XPath","//i[@class='ban icon']",5);
            unselectallicon.Click();
            
        }
        public bool UnSelectAllvalidation()
        {
            ElementExists("XPath", "//input[@type='checkbox']", 5);
            bool ischeckboxselected = checkboxicon.Selected;
            return ischeckboxselected;
        }

        public void HoverOnNotificationClickOnSeeAll()
        {
            Actions action = new Actions(Driver);
            ElementExists("XPath", "//div[text()='Notification']", 5);
            action.MoveToElement(notification).Perform();
            ElementExists("XPath", "//a[normalize-space()='See All...']", 4);
            Seeall.Click();
            //Seeall.Click();
            wait(4000);
        }

        public void ClickInsideACheckboxNearNotification()
        {
            ElementExists("XPath","//input[@type='checkbox']",6);
            CheckboxiconnearNotification.Click();
        }
        public void MarkSelectionAsReadIcon()
        {
            CheckboxiconnearNotification.Click();
        }
        public string NotificationUpdated()
        {
           string text = NotificationMessage.Text;
            return text;

        }

        public string ValidateMarkSelectionAsReadByFontSize()
        {
            ElementExists("XPath", "//div[@name='63efbefcbb8b270001f5777f']//div[@class='ui grid']//div[@id='myDIV']", 7);
            string highLightedtext = Highlightedelement.GetCssValue("font-weight");
            return highLightedtext;
        }


    }
}
