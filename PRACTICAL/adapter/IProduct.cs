using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRACTICAL.Models;

namespace PRACTICAL.adapter
{
    interface IProduct
    {
        List<Product> GetProduct();
        bool AddProduct(Product item);
    }
}
