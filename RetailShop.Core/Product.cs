using System;
using System.Collections.Generic;
using System.Text;

namespace RetailShop.Core
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public DateTime? CreatedOnDate { get; set; }
        public DateTime? ModifiedOnDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsNew { get; set; }

    }
}
