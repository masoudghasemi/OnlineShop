using Microsoft.AspNetCore.Http.Extensions;

namespace OnlineShop.WebApi.Middlewares
{
    public class LogMiddleware
    {
        private readonly RequestDelegate _next;

        public LogMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context) {


            var request = context.Request;

            await _next(context);



        }



    }



}
