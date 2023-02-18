using Advanced_Task.Pages;
using AventStack.ExtentReports;
using NUnit.Framework;
using System;

namespace Advanced_Task.Test
{
    [TestFixture]
     class Shareskilltest :Advanced_Task.Global.Base
    {
        

        [Test]
        public void CreateShareSkillTest()
        {
            
            Advanced_Task.Pages.Shareskills obj = new Advanced_Task.Pages.Shareskills();
            obj.CreateShareSkill();
            
            Advanced_Task.Pages.Managelisting obj1 = new Advanced_Task.Pages.Managelisting();
           string text = obj1.ValidateSaveSkills();

            Assert.AreEqual("I am a script writer", text);

        }



    }
}
