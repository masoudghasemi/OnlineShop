namespace OnlineShop.Application.Features.Products.AddProduct;

public class ProductNameInvalidException:Exception
{
    public string Message { get; set; }

    public ProductNameInvalidException(string message)
    {
        Message = message;
    }
}