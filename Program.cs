var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Enables static files
app.UseStaticFiles();

//making movies.html the default page
app.MapGet("/", (HttpContext context) =>
{
    var filePath = "movies.html";
    var file = context.RequestServices.GetRequiredService<IWebHostEnvironment>().WebRootFileProvider.GetFileInfo(filePath);
    
    if (file.Exists)
    {
        return Results.File(file.PhysicalPath, "text/html");
    }
    return Results.NotFound();
});

app.Run();

