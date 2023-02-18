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
    public class ManageRequestTest
    {
        [TestFixture]

        class ManageRequest : Advanced_Task.Global.Base
        {
            ExtentReports rep = ExtentManager.getInstance();
            ExtentTest test;

            [Test, Order(1)]
            public void SendRequestsToaPersonTest()
            {
                test = rep.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test started");

                Advanced_Task.Pages.Managerequests obj = new Advanced_Task.Pages.Managerequests();

                obj.SendRequeststoaperson();
                test.Log(Status.Pass, "test passed");

                rep.Flush();

            }

            [Test,Order(2)]
            public void SendRequestsToaPersonValidateTest()

            {
                test = rep.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test started");
                Advanced_Task.Pages.Managerequests obj = new Advanced_Task.Pages.Managerequests();

                obj.SendRequestValidate();
                test.Log(Status.Pass, "test passed");

                rep.Flush();
            }


            [Test,Order(3)]
            public void ReceiveRequestsToaPersonTest()
            {
                test = rep.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test started");
                Advanced_Task.Pages.Managerequests obj = new Advanced_Task.Pages.Managerequests();
                obj.ReceivedRequests();
                test.Log(Status.Pass, "test passed");

                rep.Flush();
            }

            [Test,Order(4)]
            public void ReceiveRequestsToaPersonValidateTest()
            {
                test = rep.CreateTest(TestContext.CurrentContext.Test.Name).Info("Test started");
                Advanced_Task.Pages.Managerequests obj = new Advanced_Task.Pages.Managerequests();
                obj.ReceivedRequestsvalidation();
                test.Log(Status.Pass, "test passed");

                rep.Flush();
            }


        }
    }
}


