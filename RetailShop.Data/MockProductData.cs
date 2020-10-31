using RetailShop.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RetailShop.Data
{
    public class MockProductData : IProductData
    {
        List<Product> products;

        public MockProductData()
        {
            products = new List<Product>()
            {
                new Product {
                    Id=1,
                    Name="iSmart 1000",
                    ShortDescription="256gb storage in Black",
                    LongDescription="A flagship smart phone to meet your everyday needs. 10MP Camera with zoom.",
                    Price= 599.99,
                    Category=Category.Tech,
                    CreatedOnDate=new DateTime(2020,10,23),
                    ModifiedOnDate=new DateTime(2020,10,24),
                    IsDeleted=false,
                    IsNew=true
                },
                new Product {
                    Id=2,
                    Name="Crew Neck T-Shirt",
                    ShortDescription="Plain blue classic fit, no pocket",
                    LongDescription="Made to be worn. 100% Cotton. Cold wash only",
                    Price= 29.99,
                    Category=Category.Clothing,
                    CreatedOnDate=new DateTime(2020,8,2),
                    ModifiedOnDate=new DateTime(2020,12,2),
                    IsDeleted=false,
                    IsNew=true
                },
                new Product {
                    Id=3,
                    Name="Chino Shorts",
                    ShortDescription="Sand coloured, slim fit, modern styling",
                    LongDescription="Get ready for summer with these stylish chino shorts, made to be warn with a trendy shirt. Cold wash only",
                    Price= 89.99,
                    Category=Category.Clothing,
                    CreatedOnDate=new DateTime(2020,3,16),
                    ModifiedOnDate=new DateTime(2020,2,19),
                    IsDeleted=false,
                    IsNew=false
                }
            };
        }

        public Product GetById(int id)
        {
            return products.SingleOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return products;
        }
    }
}
