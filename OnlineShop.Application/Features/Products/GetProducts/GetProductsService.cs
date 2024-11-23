using OnlineShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Features.Products.GetProducts
{
   
    public class GetProductsService : IGetProductsService
    {
      


        public List<ProductDto> Handle(GetProductsServiceRequest request)
        {
           

            var products=Product.GetProducts(request.Id);

            var ListOfProductDtos=new List<ProductDto>();

            foreach (var product in products)
            {
                ListOfProductDtos.Add(new ProductDto
                {
                    Id = product.Id,
                    Name = product.Name,
                    Category = product.Category,
                    Description = product.Description,
                });
            }

            return ListOfProductDtos;


        }
    }
}
