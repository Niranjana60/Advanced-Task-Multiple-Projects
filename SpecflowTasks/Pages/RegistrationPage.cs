using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_task__test_project.Pages
{
    public class RegistrationPage:BasePage
    {

        public RegistrationPage(IWebDriver driver) : base(driver)
        {

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
            
            //Enter FirstName
            FirstName.SendKeys("gari");

            //Enter LastName
            LastName.SendKeys("roy");

            //Enter Email
            Email.SendKeys("gariroy@gmail.com");

            //Enter Password
            Password.SendKeys("gariroy123");

            //Enter Password again to confirm
            ConfirmPassword.SendKeys("gariroy123");



        }

        public string AtHomePage()
        {
            string actualTitle = (Driver).Title;
            return actualTitle;
        }
        public void ClickCheckbox()
        {
            Checkbox.Click();
        }
        public void ClickJoinButton()
        {
            JoinBtn.Click();
        }

        public string RegistrationSuccessfullMessage()
        {
            ElementExists("XPath","//div[@class='ns-box-inner']", 7);
            String text =NotificationMessage.Text;
            return text;
        }

        public void clickOnJoinAfterfillingform()
        {
            JoinButtonAfterFillingForm.Click();
        }
     

    }
}
