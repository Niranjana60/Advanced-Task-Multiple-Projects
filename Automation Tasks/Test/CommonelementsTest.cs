using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Task.Test
{
    public class CommonelementsonscreenTest
    {
        [TestFixture]
        class Commonelementonscreen : Advanced_Task.Global.Base
        {
            [Test]
            public void chattest()
            {
                Advanced_Task.Pages.Commonelementsonscreen obj = new Advanced_Task.Pages.Commonelementsonscreen();
                obj.chatting();

                string chatmessage = obj.validatechatmessage();
                Assert.AreEqual("Hi there how are you doing?", chatmessage);

            }

         

            [Test]
            public void DeleteNotificationstest()
            {
                Advanced_Task.Pages.Commonelementsonscreen obj = new Advanced_Task.Pages.Commonelementsonscreen();
                obj.DeleteNotifications();

                string Deletenotificationmessage = obj.ValidateDeleteNotification();
               Assert.AreEqual("Notification updated", Deletenotificationmessage);
            }

            [Test]
            public void NotificationsMarkAsReadtest()
            {
                Advanced_Task.Pages.Commonelementsonscreen obj = new Advanced_Task.Pages.Commonelementsonscreen();
                obj.NotificationsMarkasReadSecond();
               // string Text = obj.ValidateNotificationsMarkasRead();
                //Assert.AreEqual("400", Text);
              

            }

            [Test]
            public void ShowLesstest()
            {
                Advanced_Task.Pages.Commonelementsonscreen obj = new Advanced_Task.Pages.Commonelementsonscreen();
                obj.ShowLess();
                bool showLess = obj.ValidateShowLess();

                Assert.IsTrue(showLess);
            }

            [Test]
            public void Loadmorenotificationtest()
            {
                Advanced_Task.Pages.Commonelementsonscreen obj = new Advanced_Task.Pages.Commonelementsonscreen();
                obj.Loadmorenotification();
                bool loadmore =obj.ValidateLoadMore();
                Assert.IsTrue(loadmore);
            }

            [Test]
            public void Selectalltest()
            {
                Advanced_Task.Pages.Commonelementsonscreen obj = new Advanced_Task.Pages.Commonelementsonscreen();
                obj.SelectAll();
                bool text = obj.SelectAllvalidation();

                Assert.AreEqual(true, text);

            }


            [Test]
            public void UnSelectalltest()
            {
                Advanced_Task.Pages.Commonelementsonscreen obj = new Advanced_Task.Pages.Commonelementsonscreen();
                obj.UnSelectAll();
                bool text = obj.UnSelectAllvalidation();

                Assert.AreEqual(false, text);

            }


            [Test]
            public void SearchSkillsbyCategoryTest()
            {
                Advanced_Task.Pages.Commonelementsonscreen obj = new Advanced_Task.Pages.Commonelementsonscreen();
                obj.searchskillsbycategory();

                bool text = obj.searchskillsbycategoryvalidation();
                Assert.AreEqual(true, text);

            }


            [Test]
            public void SearchSkillsbySubCategoryTest()
            {
                Advanced_Task.Pages.Commonelementsonscreen obj = new Advanced_Task.Pages.Commonelementsonscreen();
                obj.searchskillsbysubcategory();

                bool text = obj.searchskillsbysubcategoryvalidation();
                Assert.AreEqual(true, text);


            }

            [Test]
            public void FilterTest()
            {
                Advanced_Task.Pages.Commonelementsonscreen obj = new Advanced_Task.Pages.Commonelementsonscreen();
                obj.filter();

                bool text = obj.Validateonlinefilter();
                Assert.AreEqual(true, text);

            }
        }
    }
}
