using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Features.Products.GetProducts
{
    public interface IGetProductsService
    {

        public List<ProductDto> Handle(GetProductsServiceRequest request);

    }
}
