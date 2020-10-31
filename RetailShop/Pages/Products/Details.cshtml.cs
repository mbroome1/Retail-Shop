using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RetailShop.Core;
using RetailShop.Data;

namespace RetailShop.Pages.Products
{
    public class DetailsModel : PageModel
    {
        private readonly IProductData productData;

        public Product Product { get; set; }
        public DetailsModel(IProductData productData)
        {
            this.productData = productData;
        }
        public IActionResult OnGet(int productId)
        {
            Product = productData.GetById(productId);
            if (Product == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }
    }
}
