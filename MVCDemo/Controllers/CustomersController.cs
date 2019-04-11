using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class CustomersController : Controller
    {
        public IActionResult Index()
        {
            var model = new List<MVCDemo.Models.Customer>()
            {
                new Models.Customer() { Name="Alice Adams", Address1="", City="Manchester" },
                new Models.Customer() { Name="Bob Brown", Address1="", City="Bristol" },
                new Models.Customer() { Name="Charlie Clarke", Address1="", City="London" }
            };

            return View(model);
        }
    }
}