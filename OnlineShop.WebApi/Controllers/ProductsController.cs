using Microsoft.AspNetCore.Mvc;
using OnlineShop.Application.Features.Products.AddProduct;
using OnlineShop.Application.Features.Products.GetProducts;

namespace OnlineShop.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductsController : ControllerBase
    {
        private readonly IAddProductService _addProductService;
        private readonly IGetProductsService _getProductsService;

        public ProductsController(IAddProductService addProductService, IGetProductsService getProductsService)
        {

            _addProductService = addProductService;
            _getProductsService = getProductsService;
        }


        // سرویس افزودن محصول

        [HttpPost]
        public AddProductServiceResponse AddProduct(AddProductServiceRequest request)
        {

            var response = _addProductService.Handle(request);
            return response;

        }

        [HttpPost]
        public List<ProductDto> GetProducts(GetProductsServiceRequest request)
        {

            var response = _getProductsService.Handle(request);
            return response;

        }




        // سرویس حذف محصول


        // سرویس ویرایش محصول



        // سرویس دریافت اطلاعات یک محصول



        // سرویس دریافت اطلاعات لیستی از محصولات
    }
}
