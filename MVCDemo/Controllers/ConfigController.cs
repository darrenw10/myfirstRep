using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCDemo.Controllers
{
    public class ConfigController : Controller
    {
        private IConfiguration config;

        public ConfigController(IConfiguration config)
        {
            this.config = config;
        }
        public IActionResult Index()
        {
            return Content(config.GetValue<string>("email:server"));
        }
    }
}
