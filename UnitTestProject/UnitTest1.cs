using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class DIControllerTests
    {
        [TestMethod]
        public void DIController_Index_Action_Returns_Content()
        {
            var mockNotificationSender = new MockNotificationSender();
            var controller = new MVCDemo.Controllers.DIController(mockNotificationSender);

            var result = controller.Index();

            Assert.IsInstanceOfType(result, typeof(ContentResult));
        }

        [TestMethod]
        public void DIController_Index_Action_Returns_Content_Index()
        {
            var mockNotificationSender = new MockNotificationSender();
            var controller = new MVCDemo.Controllers.DIController(mockNotificationSender);

            var result = controller.Index();

            Assert.AreEqual("Index", ((ContentResult)result).Content);
        }

        [TestMethod]
        public void DIController_Index_Action_Notifies_User()
        {
            var mockNotificationSender = new MockNotificationSender();
            var controller = new MVCDemo.Controllers.DIController(mockNotificationSender);

            var result = controller.Index();

            Assert.AreEqual("Runing Index Action", mockNotificationSender.MessageSent);
        }
    }

    public class MockNotificationSender : MVCDemo.INotificationSender
    {
        public string MessageSent { get; set; }
        public void SendNotification(string message)
        {
            this.MessageSent = message;
        }
    }
}
