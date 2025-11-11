using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SistemaAcademia.Areas.Identity.Data;
using SistemaAcademia.Data;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("SistemaAcademiaContextConnection") ?? throw new InvalidOperationException("Connection string 'SistemaAcademiaContextConnection' not found.");

builder.Services.AddDbContext<SistemaAcademiaContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<SistemaAcademiaUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<SistemaAcademiaContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
