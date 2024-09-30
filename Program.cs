var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
var app = builder.Build();

//non default convetional route #1
app.MapControllerRoute(
    name: "nondefault route1",
    pattern: "custom/home/{action}/{id?}",
    defaults: new{controller = "Home", action = "Index"}
);

//second non default route
app.MapControllerRoute(
    name: "nondefault rout2",
    pattern: "products/{action}/{id?}",
    defaults: new { controller = "Product", action = "Info" }
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();

