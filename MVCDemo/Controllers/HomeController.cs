using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(string message, Info myInfo)
        {
            if (ModelState.IsValid)
            {
                // Do update
            }
            else
            {
                ModelState.AddModelError("", "Missing message");
            }


            return Content($"ModelState {ModelState.IsValid}\nmyInfo.id - {myInfo.ID}\nmyInfo.message {myInfo.Message}\nmyInfo.isActive {myInfo.IsActive}\nmessage{message}");
        }

        public IActionResult Message(string messageTitle, string messageBody)
        {
            ViewData["MessageTitle"] = messageTitle;
            ViewBag.MessageBody = messageBody;

            return View();
        }

        public IActionResult Simple() => View();
        public IActionResult SimpleWithModel()
        {
            var model = new Info()
            {
                ID = 42,
                Message = "Hello from the model",
                IsActive = true
            };

            return View(model);
        }


        public IActionResult Forum(string message)
        {
            ViewData["Message"] = message;
            return View();
        }
    }

    public class Info
    {
        public int ID { get; set; }
        [Required]
        public string Message { get; set; }
        public bool IsActive { get; set; }
    }
}
