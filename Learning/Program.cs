var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.Run(async (HttpContext context) =>
{
    var path = context.Request.Path;
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync($"<h3>{path}</h3>");
});

app.Run();
