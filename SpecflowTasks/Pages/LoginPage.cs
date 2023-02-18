using Advanced_task__test_project.Pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Threading;

namespace Advanced_task__test_project.Pages
{
     class LoginPage:BasePage
    {
        
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        #region  Initialize Web Elements 
        //Finding the Join 
        [FindsBy(How = How.XPath, Using = "//*[@id='home']/div/div/div[1]/div/button")]
        private IWebElement Join { get; set; }
        //Finding the Signin button
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Sign')]")]

        private IWebElement signInButton { get; set; }
        //Finding the email
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[1]/input")]

        private IWebElement email { get; set; }
        //Finding the password
        [FindsBy(How = How.XPath, Using = "//INPUT[@type='password']")]

        private IWebElement passwordelement { get; set; }
        //Finding the loginbutton
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Login')]")]

        private IWebElement loginButton { get; set; }
        //Finding the profile
        [FindsBy(How = How.XPath, Using = "//body[1]/div[1]/div[1]/section[1]/div[1]/a[2]")]

        private IWebElement profile { get; set; }

        #endregion

        //Navigate to url
        public void Navigate(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }


        //click on SignIn Button
        public void ClickSignInButton()
        {
            ElementExists("X Path","//a[contains(text(),'Sign')]", 2);
            signInButton.Click();
        }

       // Add credentials email and password
        public void AddCredentials(string Email, string Password)
        {
            ElementExists("X Path", "/html/body/div[2]/div/div/div[1]/div/div[1]/input", 2);
            // Console.WriteLine("emailaddress:>>>>>>>>>>>>>>>>"+ emailaddress);
            //Enter email
            email.SendKeys(Email);

            //Enter Password
            passwordelement.SendKeys(Password);
        }

        public void AddEmail(string Email)
        {
            email.SendKeys(Email);
        }

        public void AddPassword(string Password)
        {
            passwordelement.SendKeys(Password);
        }

        public void ClickLoginButton()
        {
            ElementExists("X Path","//button[contains(text(),'Login')]",5);

            loginButton.Click();
            
        }

        public void QuickLogin(String url, String email, String password)
        {
            Navigate(url);
            ClickSignInButton();
            AddCredentials(email, password);
            ClickLoginButton();
            Driver.Manage().Window.Maximize();
            Thread.Sleep(6000);
           // wait(7000);
        }

        public bool ValidateLogin()
        {
            ElementExists("XPath", "//body[1]/div[1]/div[1]/section[1]/div[1]/a[2]", 5);

            String expectedtitle = "Profile";
            String actualtitle = profile.Text;
            if (actualtitle == expectedtitle)
            {
                Console.WriteLine("test passed");
                return true;
            }
            else
            {
                Console.WriteLine("test failed");
                return false;
            }

        }
    }
}
