using Advanced_Task.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Advanced_Task.Pages
{
    class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]
        
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]
        private IWebElement LoginBtn { get; set; }

        #endregion

        internal void LoginSteps()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");
            string url = GlobalDefinitions.ExcelLib.ReadData(1, "url");
            string email = GlobalDefinitions.ExcelLib.ReadData(1, "email");
            string password = GlobalDefinitions.ExcelLib.ReadData(1, "password");
            Global.GlobalDefinitions.driver.Navigate().GoToUrl(url);
            Global.GlobalDefinitions.wait(8);
            SignIntab.Click();
            Global.GlobalDefinitions.wait(7);
            Email.SendKeys(email);
            Global.GlobalDefinitions.wait(7);
            Password.SendKeys(password);
            Global.GlobalDefinitions.wait(2);
            LoginBtn.Click();

        }


        internal void LoginStepssecond()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");
            string url = GlobalDefinitions.ExcelLib.ReadData(2, "url");
            string email = GlobalDefinitions.ExcelLib.ReadData(2, "email");
            string password = GlobalDefinitions.ExcelLib.ReadData(2, "password");
            Global.GlobalDefinitions.driver.Navigate().GoToUrl(url);
            Global.GlobalDefinitions.wait(8);
            SignIntab.Click();
            Global.GlobalDefinitions.wait(7);
            Email.SendKeys(email);
            Global.GlobalDefinitions.wait(7);
            Password.SendKeys(password);
            Global.GlobalDefinitions.wait(2);
            LoginBtn.Click();
        }


    }
}