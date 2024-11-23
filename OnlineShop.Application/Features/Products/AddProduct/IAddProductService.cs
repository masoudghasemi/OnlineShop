using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Features.Products.AddProduct
{
    public interface IAddProductService
    {

        public AddProductServiceResponse Handle(AddProductServiceRequest request);

    }
}
