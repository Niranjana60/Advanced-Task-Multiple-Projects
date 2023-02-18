using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Task.Test
{
    [TestFixture]
     class Registrationtest : Advanced_Task.Global.Base
    {
        [Test]

        public void RegistrationDetails()
        {
            Advanced_Task.Pages.Registration obj = new Advanced_Task.Pages.Registration();
            obj.RegisterDetails();
        }

        public void ValidateRegistration()
        {
            Advanced_Task.Pages.Registration obj = new Advanced_Task.Pages.Registration();
            string message =obj.RegistrationSuccessfullMessage();

            Assert.AreEqual("Registration successful", message);
        }


    }
}
