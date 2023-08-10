using Microsoft.EntityFrameworkCore;
using Pronia.Contexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
//builder.Services.AddDbContext<AppDbContext>(options => {
//    //options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
//    options.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=ProniaDB;TrustServerCertificate=True");
//    //options.UseSqlServer(builder.Configuration["ConnectionStrings:Default"]);
//});
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer("Server=MSI\\SQLEXPRESS;Database=ProniaDbase;Trusted_Connection=True;TrustServerCertificate=True;");
});


var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
);

app.MapControllerRoute(
    name: "Default",
    pattern: "{Controller=Home}/{Action=Index}/{Id?}"
);

app.Run();
