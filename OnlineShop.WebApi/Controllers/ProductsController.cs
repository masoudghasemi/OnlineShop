using Microsoft.AspNetCore.Mvc;
using OnlineShop.Application.Features.Products.AddProduct;
using OnlineShop.Application.Features.Products.GetProducts;
using OnlineShop.WebApi.ExtentionMethods;

namespace OnlineShop.WebApi.Controllers
{
    
    public delegate int Calculator(int a, int b);

    
    
    
    [ApiController]
    [Route("[controller]/[action]")]
    public class ProductsController : ControllerBase
    {

        public int SumCalculator(int a, int b)
        {

            return a + b;
        }
        
        
        public int MinusCalculator(int a, int b)
        {

            return a - b;
        }

        public int CrossCalculator(int f, int g)
        {
            return f * g;
        }



        public int Calculate(int a, int b, Calculator calculator)
        {
             return calculator(a, b);
        }
        
        
        
        // /////////////////////////////////////////////////////////////////
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


            var result = Calculate(200, 100, SumCalculator);

            var resultOfMinus = Calculate(200, 100, MinusCalculator);

            var resultOfCross = Calculate(100, 200, CrossCalculator);
            
            var welcomeMessage = _configuration["wellcomeMessage"];
            
            //var stringNumber = "132546";
            //var intNumber = stringNumber.ConvertToInt();

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
