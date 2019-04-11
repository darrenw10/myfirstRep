using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCDemo.Controllers
{
    public class DIController : Controller
    {
        private INotificationSender notificationSender;
        private ILoggerFactory loggerFactory;

        public DIController(INotificationSender notificationSender/*, ILoggerFactory logger*/)
        {
            this.notificationSender = notificationSender;
            //this.loggerFactory = logger;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            if (loggerFactory != null)
            {
                var logger = loggerFactory.CreateLogger("TEST");
                logger.Log(LogLevel.Critical, "Danger Will Robinson");
            }
            notificationSender.SendNotification("Runing Index Action");
            return Content("Index");
        }
    }
}
