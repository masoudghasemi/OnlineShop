using OnlineShop.Application.Formules.ProductAmountCalculator;
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
        private readonly IProductAmountCalculator _productAmountCalculator;

        public AddProductService(IProductAmountCalculator productAmountCalculator) {

            _productAmountCalculator = productAmountCalculator;
        }


        public AddProductServiceResponse Handle(AddProductServiceRequest request)
        {

            if (request.Name.Length > 20 )
            {
               // return null;

               throw new ProductNameInvalidException("طول نام وارد شده معتبر نیست");
            }



            var product=new Product()
            {
                Name= request.Name,
                Description= request.Description,
                Category= request.Category,
                Amount= _productAmountCalculator.Calculate(request.Category)
            };


           var id= Product.AddProduct(product);


            return new AddProductServiceResponse
            {
                Id= id,
            };


        }
    }
}
