using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace CustomMiddleWare
{
    public class CustomMiddleWare : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("Hello from New file-1 \n");
            await next(context);
            await context.Response.WriteAsync("Hello from New file-2 \n");
        }
    }
}
