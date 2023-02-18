using Advanced_Task.Global;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Task.Pages
{
    class Registration
    {

        public Registration()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }
        #region  Initialize Web Elements 
        //Finding the Join 
        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/button")]
        private IWebElement Join { get; set; }

        //Identify FirstName Textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='First name']")]
        private IWebElement FirstName { get; set; }

        //Identify LastName Textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Last name']")]
        private IWebElement LastName { get; set; }

        //Identify Email Textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email address']")]
        private IWebElement Email { get; set; }

        //Identify Password Textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Password']")]
        private IWebElement Password { get; set; }

        //Identify Confirm Password Textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Confirm Password']")]
        private IWebElement ConfirmPassword { get; set; }

        //Identify Term and Conditions Checkbox
        [FindsBy(How = How.XPath, Using = "//input[@name='terms']")]
        private IWebElement Checkbox { get; set; }

        //Identify join button
        [FindsBy(How = How.XPath, Using = "//button[@class='ui green basic button']")]
        private IWebElement JoinBtn { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='ns-box-inner']")]
        private IWebElement NotificationMessage { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@id='submit-btn']")]
        private IWebElement JoinButtonAfterFillingForm { get; set; }
        #endregion

        public void RegisterDetails()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Registration");
            string url = GlobalDefinitions.ExcelLib.ReadData(1, "url");
            string firstName = GlobalDefinitions.ExcelLib.ReadData(1, "FirstName");
            string lastName = GlobalDefinitions.ExcelLib.ReadData(1, "LastName");
            string email = GlobalDefinitions.ExcelLib.ReadData(1, "email");
            string password = GlobalDefinitions.ExcelLib.ReadData(1, "password");
            string confirmPassword= GlobalDefinitions.ExcelLib.ReadData(1, "confirmPassword");

            Global.GlobalDefinitions.driver.Navigate().GoToUrl(url);

            Global.GlobalDefinitions.wait(8);
            JoinBtn.Click();
            //Enter FirstName
            FirstName.SendKeys(firstName);

            //Enter LastName
            LastName.SendKeys(lastName);

            //Enter Email
            Email.SendKeys(email);

            //Enter Password
            Password.SendKeys(password);

            //Enter Password again to confirm
            ConfirmPassword.SendKeys(confirmPassword);

            Checkbox.Click();

            JoinButtonAfterFillingForm.Click();

        }

        public string AtHomePage()
        {
            string actualTitle = GlobalDefinitions.driver.Title;
            return actualTitle;
        }
      

        public string RegistrationSuccessfullMessage()
        {
            Global.GlobalDefinitions.ElementExists("XPath", "//div[@class='ns-box-inner']", 7);
            String text = NotificationMessage.Text;
            return text;
        }

        


    }
}
