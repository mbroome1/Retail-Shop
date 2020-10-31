using RetailShop.Core;
using System.Collections.Generic;
using System.Text;

namespace RetailShop.Data
{
    public interface IProductData
    {
        IEnumerable<Product> GetProducts();
        Product GetById(int id);
    }
}
