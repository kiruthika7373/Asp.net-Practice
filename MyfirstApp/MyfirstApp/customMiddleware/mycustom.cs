namespace MyfirstApp.customMiddleware
{
    public class mycustom : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("my custome middle ware start");
            await next(context);
            await context.Response.WriteAsync("my custome middleware last");
        }
    }
}
