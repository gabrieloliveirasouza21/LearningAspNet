var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    context.Response.ContentType = "text/html";

    if (context.Request.Headers.ContainsKey("User-Agent"))
    {
        var userAgent = context.Request.Headers.UserAgent.ToString();
        await context.Response.WriteAsync(userAgent);
    }

});

app.Run();
