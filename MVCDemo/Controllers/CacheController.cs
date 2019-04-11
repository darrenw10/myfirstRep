using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVCDemo.Controllers
{
    public class CacheController : Controller
    {
        private IDistributedCache cache;

        public CacheController(IDistributedCache cache)
        {
            this.cache = cache;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var customer = (Customer)Deserialise(cache.Get("Customer.42"));

            if (customer == null)
            {
                customer = GetCustomer();
                cache.Set("Customer.42", Serialise(customer),
                    new DistributedCacheEntryOptions
                    {
                        AbsoluteExpirationRelativeToNow = TimeSpan.FromMinutes(30),
                        SlidingExpiration = TimeSpan.FromMinutes(1)
                    });
            }


            return View(customer);
        }

        [ResponseCache(CacheProfileName = CacheProfiles.Never)]
        public IActionResult CachedPage() => Content("Page");

        private byte[] Serialise(object o)
        {
            var formatter = new BinaryFormatter();
            using (var stream = new System.IO.MemoryStream())
            {
                formatter.Serialize(stream, o);

                return stream.ToArray();
            }
        }

        private object Deserialise(byte[] data)
        {
            if (data == null)
                return null;

            var formatter = new BinaryFormatter();
            using (var stream = new System.IO.MemoryStream(data))
            {
                return formatter.Deserialize(stream);
            }
        }




        private Customer GetCustomer()
        {
            System.Threading.Thread.Sleep(3000);
            return new Customer { Name = "Alice Adams" };
        }
    }

    [Serializable]
    public class Customer
    {
        public string Name { get; set; }
        public DateTime CreateDateTime { get; } = DateTime.Now;
    }
}
