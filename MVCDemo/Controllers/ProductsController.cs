using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Models.ProductViewModel());
        }

        [HttpPost]
        public IActionResult Create(Models.ProductViewModel model)
        {
            if (ModelState.IsValid)
                return RedirectToAction(nameof(Saved));
            else
                return View(model);
        }

        public IActionResult Saved() => View();

    }
}