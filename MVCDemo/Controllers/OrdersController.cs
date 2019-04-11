using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVCDemo.Controllers
{
    [Route("/[controller]/[action]")]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class OrdersController : Controller
    {
        public IActionResult Index() => Content("Index");

        [Route("/QuickOrders")]
        public IActionResult List() => Content("List");

        [Route("{orderId}/{customerId}")]
        public IActionResult Details(int orderId, int customerId) => Content($"Details({orderId}, {customerId})");


        [Route("{orderId}")]
        public IActionResult Edit(int orderId) => Content("Edit");
    }
}