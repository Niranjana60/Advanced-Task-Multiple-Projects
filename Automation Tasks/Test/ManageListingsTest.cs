using Advanced_Task.Pages;
using AventStack.ExtentReports;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Task.Test
{
    public class ManageListingsTest
    {
        [TestFixture]
        class ManageListingTest : Advanced_Task.Global.Base
        {
            ExtentReports rep = ExtentManager.getInstance();
            ExtentTest test;

            [Test]
            public void EditManageListingstest()

            {
               
                test = rep.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test started");
                Advanced_Task.Pages.Managelisting obj = new Advanced_Task.Pages.Managelisting();
                obj.EditManageListings();
                test.Log(Status.Pass,"test passed");
               rep.Flush();
                string Text = obj.validateeditManageListings();
                Assert.AreEqual("I provide writing scripts", Text);
            }

            [Test]
            public void DeleteManageListings()
            {
                test = rep.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test started");
                Advanced_Task.Pages.Managelisting obj = new Advanced_Task.Pages.Managelisting();
                obj.DeleteManageListings();
                test.Log(Status.Pass, "test passed");
                rep.Flush();

                bool Text = obj.ValidateDeleteManageListings();
                Assert.AreEqual(true, Text);

            }

        }
    }
}
