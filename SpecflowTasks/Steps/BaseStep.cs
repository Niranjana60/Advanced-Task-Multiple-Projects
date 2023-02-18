using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_task__test_project.Steps
{
   public abstract class BaseStep : IDisposable
    {
        private IWebDriver driver;

        public BaseStep()
        {
           // this.Driver = new ChromeDriver();
            this.driver = new FirefoxDriver();
        }

        protected IWebDriver Driver { get => driver; set => driver = value; }

        public void Dispose()
        {
           // this.Driver.Close();
            this.Driver.Quit();
        }
    }
}
