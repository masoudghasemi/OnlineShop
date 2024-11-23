using OnlineShop.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Application.Features.Products.AddProduct
{
   
    public class AddProductService : IAddProductService
    {
        public AddProductServiceResponse Handle(AddProductServiceRequest request)
        {
            

            var product=new Product()
            {
                Name= request.Name,
                Description= request.Description,
                Category= request.Category,
            };


           var id= Product.AddProduct(product);


            return new AddProductServiceResponse
            {
                Id= id,
            };


        }
    }
}
