using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Task.Test
{
    [TestFixture]
    class SigninTest : Advanced_Task.Global.Base
    {
        [Test]

        public void SignInTest()
        {
            Advanced_Task.Pages.SignIn obj = new Advanced_Task.Pages.SignIn();
            obj.LoginSteps();
        }

        public void SignInValidation()
        {
            Advanced_Task.Pages.Profile obj = new Advanced_Task.Pages.Profile();
            string text = obj.LoggedinSuccessfully();
            Assert.AreEqual("Profile", text);
        }
    }
}
