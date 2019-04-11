using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCDemo.Models
{
    public class ProductViewModel
    {
        [Required(ErrorMessage = "You cannot add a product without a unit price")]
        [Display(Name = "Unit Price", Prompt = "Enter the price for a SINGLE item")]
        public double UnitPrice { get; set; }
        public bool AddSalesTax { get; set; }
        public int CategoryID { get; set; }

        public List<SelectListItem> Categories { get; set; } = new List<SelectListItem>()
        {
            new SelectListItem() { Value = "1", Text = "Hardware" },
            new SelectListItem() { Value = "2", Text = "Software" },
            new SelectListItem() { Value = "3", Text = "Delivery" },
            new SelectListItem() { Value = "4", Text = "Misc", Disabled = true }
        };

    }

}
