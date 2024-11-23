using OnlineShop.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Features.Products.AddProduct
{
    public class AddProductServiceRequest
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public ProductCategory Category { get; set; }
    }
}
