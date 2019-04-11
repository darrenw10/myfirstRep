using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Models
{
    public class StateViewModel
    {
        public int QueryStringCount { get; set; }
        public int FormCount { get; set; }

        public int SessionCount { get; set; }
        public int CookieCount { get; set; }
    }
}
