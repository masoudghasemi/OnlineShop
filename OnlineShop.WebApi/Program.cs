using OnlineShop.Application.Features.Products.AddProduct;
using OnlineShop.Application.Features.Products.GetProducts;
using OnlineShop.Application.Formules.ProductAmountCalculator;
using OnlineShop.WebApi.Middlewares;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAddProductService, AddProductService>();
builder.Services.AddScoped<IGetProductsService, GetProductsService>();
builder.Services.AddSingleton<IProductAmountCalculator, ProductAmountCalculator>();


var app = builder.Build();

//app.UseMiddleware<LogMiddleware>();
 app.UseLogMiddleware();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); 

app.UseAuthorization();



app.MapControllers();





app.Run();
