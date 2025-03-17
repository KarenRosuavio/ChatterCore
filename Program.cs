var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", async context => {
    var homepagehtml = await File.ReadAllTextAsync("html/index.html");
    context.Response.ContentType = "text/html";
    await context.Response.WriteAsync(homepagehtml);
    });
app.Run();
