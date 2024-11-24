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
        private readonly IConfiguration _configuration;

        public ProductsController(IAddProductService addProductService, IGetProductsService getProductsService, IConfiguration configuration)
        {

            _addProductService = addProductService;
            _getProductsService = getProductsService;
            _configuration = configuration;
        }


        // سرویس افزودن محصول

        [HttpPost]
        public AddProductServiceResponse AddProduct(AddProductServiceRequest request)
        {

            var welcomeMessage = _configuration["wellcomeMessage"];


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
