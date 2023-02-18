using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;

namespace Advanced_task__test_project.Pages
{
    public abstract class BasePage
    {
        private IWebDriver driver;

        protected IWebDriver Driver { get => driver; set => driver = value; }

        public BasePage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(Driver, this);
        }


        public void wait(int time)
        {
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(time);

        }
        public void ElementExists(String locator, string locatorValue, int seconds)
        {

            try
            {
                if (locator == "Id")
                {
                    var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Id(locatorValue)));
                }

                if (locator == "XPath")
                {
                    Console.WriteLine(">>>>>>>>>> Adding Wait");
                    var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(locatorValue)));
                }

                if (locator == "LinkText")
                {
                    Console.WriteLine(">>>>>>>>>> Adding Wait");
                    var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.LinkText(locatorValue)));
                }

                if (locator == "Name")
                {
                    Console.WriteLine(">>>>>>>>>> Adding Wait");
                    var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(seconds));
                    wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.Name(locatorValue)));
                }


            }

            catch (Exception ex)
            {
                Assert.Fail("Test Failed waiting for element to exists", ex.Message);
            }
        }

        internal void ElementExists(object driver, string v1, string v2, int v3)
        {
            throw new NotImplementedException();
        }

        public void LoginCommon()
        {
            ElementExists("XPath", "//input[@placeholder='Email address']", 3);
            IWebElement email = driver.FindElement(By.XPath("//input[@placeholder='Email address']"));
            email.SendKeys("herrasaad@gmail.com");
            //IWebElement password = driver.FindElement(By.XPath("//INPUT[@type='password'"));
            IWebElement password = driver.FindElement(By.XPath("//input[@placeholder='Password']"));
            password.SendKeys("herrasaad@123");
            IWebElement loginButton = driver.FindElement(By.XPath("//BUTTON[@class='fluid ui teal button'][text()='Login']"));
            loginButton.Click();
            driver.Manage().Window.Maximize();
            wait(2000);
           
        }

    }
}
    

