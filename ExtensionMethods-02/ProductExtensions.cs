using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods_02
{
    internal static class ProductExtensions
    {
        public static Product ApplyDiscount(this Product product, decimal discount)
        {
            product.Price = product.Price - (product.Price * (discount / 100));
            return product;
        }
    }
}
