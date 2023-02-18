using Advanced_Task.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Task.Test
{
    [TestFixture]
    class Profilepagetest : Advanced_Task.Global.Base
    {
        
        [Test]
        public void AvailabilityType()
        {
            Profile profileobj = new Advanced_Task.Pages.Profile();
            profileobj.AvailabilityType();
            bool AvailText = profileobj.validateAvailabilityType();
            Assert.AreEqual(true, AvailText);
            //Assert.AreEqual("Part Time", AvailText);
        }


        [Test]
        public void EarnTarget()
        {
            Advanced_Task.Pages.Profile profileobj = new Advanced_Task.Pages.Profile();
            profileobj.EarnTarget();
            bool EarnText = profileobj.validateEarnTarget();

            Assert.AreEqual(true, EarnText);

        }

        [Test]
        public void Hours()
        {
            Advanced_Task.Pages.Profile profileobj = new Advanced_Task.Pages.Profile();
            profileobj.Hours();
            bool Hour = profileobj.validateHours();

            Assert.AreEqual(true, Hour);

        }

        [Test]
        public void AddDescriptionTest()
        {

            Advanced_Task.Pages.Profile profileobj = new Advanced_Task.Pages.Profile();
            profileobj.AddDescription();
         
            bool Text = profileobj.ValidateDescriptionText();
            Assert.AreEqual(true, Text);
        }

        [Test]
        public void AddLanguages()
        {
            Advanced_Task.Pages.Profile profileobj = new Advanced_Task.Pages.Profile();
            profileobj.ADDLanguage();

            bool Text = profileobj.validateADDLanguage();
            Assert.AreEqual(true, Text);

            bool Textone = profileobj.validateADDLanguagelevel();
            Assert.AreEqual(true, Textone);

        }


        [Test]
        public void ADDSkill()
        {
            Advanced_Task.Pages.Profile profileobj = new Advanced_Task.Pages.Profile();
            profileobj.ADDSkill();

            bool Text = profileobj.validateSkillisAdded();
            Assert.AreEqual(true, Text);

            bool Textone = profileobj.validateSkilllevelisAdded();
            Assert.AreEqual(true, Textone);
        }


        [Test]
        public void ADDEducation()
        {
            Advanced_Task.Pages.Profile profileobj = new Advanced_Task.Pages.Profile();
            profileobj.AddEducation();

            bool collegename = profileobj.validatecollegename();
            Assert.AreEqual(true, collegename);

            bool countryofcollege = profileobj.validatecollegename();
            Assert.AreEqual(true, countryofcollege);

            bool titleincollege = profileobj.validatetitle();
            Assert.AreEqual(true, titleincollege);

            bool degree = profileobj.validatedegree();
            Assert.AreEqual(true, degree);

            bool graduationyear = profileobj.validategraduationyear();
            Assert.AreEqual(true, graduationyear);


        }

        [Test]
        public void AddCertification()
        {
            Advanced_Task.Pages.Profile profileobj = new Advanced_Task.Pages.Profile();
            profileobj.AddCertification();

            bool certificateadded = profileobj.validateCertificate();
            Assert.AreEqual(true, certificateadded);

            bool certifiedfrom = profileobj.validateCertifiedfrom();
            Assert.AreEqual(true, certifiedfrom);

            bool Certifiedyear = profileobj.validateCertifiedyear();
            Assert.AreEqual(true, Certifiedyear);



        }


        }

}

        


    



    



       



    







