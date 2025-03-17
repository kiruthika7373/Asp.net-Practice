using MyfirstApp.customMiddleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<mycustom>();
var app = builder.Build();
//middleware1
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello");
    await next(context);
});
//middleare 2
app.UseMiddleware<mycustom>();

//middleware 3
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("kiruthi");
});
//everthing should be stored in githubfdfaS


app.Run();
