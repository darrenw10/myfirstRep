using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCDemo.Controllers
{
    public class StateController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index(StateViewModel model)
        {
            model = model ?? new StateViewModel();

            model.QueryStringCount++;
            model.FormCount++;

            model.SessionCount = HttpContext.Session.GetInt32("Count").GetValueOrDefault();
            model.SessionCount++;
            HttpContext.Session.SetInt32("Count", model.SessionCount);

            model.CookieCount = int.Parse(Request.Cookies["Count"] ?? "0");
            model.CookieCount++;
            Response.Cookies.Append("Count", model.CookieCount.ToString(), new CookieOptions { Expires = DateTime.Today.AddYears(2) });

            return View(model);
        }
    }
}
