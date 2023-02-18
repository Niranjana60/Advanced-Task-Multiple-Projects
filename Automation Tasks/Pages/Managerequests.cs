using Advanced_Task.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Advanced_Task.Pages
{
    class Managerequests
    {
        public Managerequests()
        {
            PageFactory.InitElements(Advanced_Task.Global.GlobalDefinitions.driver, this);

        }

        #region  Initialize Web Elements 
        //Type the searchbox
        [FindsBy(How = How.XPath, Using = "//div[@class='ui secondary menu']//input[@placeholder='Search skills']")]
        private IWebElement searchbox { get; set; }

        //searchicon
        [FindsBy(How = How.XPath, Using = "//i[@class='search link icon']")]
        private IWebElement searchicon { get; set; }

        //searchuser
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search user']")]
        private IWebElement searchuser { get; set; }

        //searchuserimage
        [FindsBy(How = How.XPath, Using = "//img[@class='ui avatar circular image']")]
        private IWebElement searchuserimage { get; set; }

        //userimage
        [FindsBy(How = How.XPath, Using = "//a[@class='image']//img")]
        private IWebElement userimage { get; set; }

        //messagebox
        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='I am interested in trading my cooking skills with your coding skills..']")]
        private IWebElement messagebox { get; set; }

        //Requestbutton
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'button')]")]
        private IWebElement Requestbutton { get; set; }

        //ManageRequests
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[1]/div/div[1]")]
        private IWebElement Managerequest { get; set; }

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

        //Receivedrequestlink
        [FindsBy(How = How.XPath, Using = "//a[normalize-space()='Received Requests']")]
        private IWebElement Receivedrequest { get; set; }

        //Acceptbutton
        [FindsBy(How = How.XPath, Using = "//tbody/tr[1]/td[8]/button[1]")]
        private IWebElement Acceptbutton { get; set; }


        #endregion

        public void SendRequeststoaperson()
        {
            Global.GlobalDefinitions.ElementExists("XPath", "//i[@class='search link icon']", 7);
            searchicon.Click();
            searchuser.SendKeys("blippi");
            searchuserimage.Click();
            Global.GlobalDefinitions.ElementExists("XPath", "//a[@class='image']//img", 4);
            userimage.Click();
            Global.GlobalDefinitions.ElementExists("XPath", "//textarea[@placeholder='I am interested in trading my cooking skills with your coding skills..']", 2);
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageRequests");
            string AddLanguagenew = GlobalDefinitions.ExcelLib.ReadData(1, "Send Request");
            // messagebox.SendKeys("I am peppa.I am interested in sharing my astro skills with your amazing writing skills");
            messagebox.SendKeys(AddLanguagenew);
            Requestbutton.Click();
            yes.Click();
            Global.GlobalDefinitions.wait(3000);



        }

        public void SendRequestValidate()
        {

            Actions action = new Actions(Global.GlobalDefinitions.driver);
            action.MoveToElement(Managerequest).Perform();
            Global.GlobalDefinitions.ElementExists("LinkText", "Sent Requests", 6);

            Sendrequests.Click();

            int rowcount = rownumber.Count();
            Console.WriteLine(rowcount);
            
            int colcount = columnsnumber.Count();
            Console.WriteLine(colcount);
            for (int i = 1; i <= rowcount; i++)
            {
                for(int j = 1; j <= colcount; j++)
                {
                    Console.WriteLine( Global.GlobalDefinitions.driver.FindElement(By.XPath("/ html[1] / body[1] / div[1] / div[1] / div[1] / div[2] / div[1] / table[1] / tbody[1] / tr[" + i + "] / td[" + j + "]")).Text);
                    

                }
                
            }

        }

        public void ReceivedRequests()
        {
            Actions action = new Actions(Global.GlobalDefinitions.driver);
            Global.GlobalDefinitions.ElementExists("XPath", "/html/body/div[1]/div/section[1]/div/div[1]", 3);

            action.MoveToElement(Managerequest).Perform();
            Receivedrequest.Click();
          
        }

        public void ReceivedRequestsvalidation()
        {
            Actions action = new Actions(Global.GlobalDefinitions.driver);
            Global.GlobalDefinitions.ElementExists("XPath", "/html/body/div[1]/div/section[1]/div/div[1]", 3);
            action.MoveToElement(Managerequest).Perform();
            Receivedrequest.Click();
            Thread.Sleep(9000);
            Global.GlobalDefinitions.ElementExists("XPath", "//tbody/tr[2]/td[8]/button[1]", 82);
            int rowcount = rownumber.Count();
            Console.WriteLine(rowcount);
            int colcount = columnsnumber.Count();
            Console.WriteLine(colcount);
            for (int i = 1; i <= rowcount; i++)
            {
                for (int j = 1; j <= colcount; j++)
                {
                    Console.WriteLine(Global.GlobalDefinitions.driver.FindElement(By.XPath("/ html[1] / body[1] / div[1] / div[1] / div[1] / div[2] / div[1] / table[1] / tbody[1] / tr[" + i + "] / td[" + j + "]")).Text);


                }

            }
        }


    }
}

