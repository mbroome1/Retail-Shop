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
    public class IndexModel : PageModel
    {
        private readonly IProductData productData;

        public IEnumerable<Product> Products { get; set; }
        public IndexModel(IProductData productData)
        {
            this.productData = productData;
        }
        public void OnGet()
        {
            Products = productData.GetProducts();
        }
    }
}
