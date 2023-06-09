using bmerketo_ASPNET_core_MVC.Contexts;
using bmerketo_ASPNET_core_MVC.Factories;
using bmerketo_ASPNET_core_MVC.Repositories;
using bmerketo_ASPNET_core_MVC.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Connection Strings
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));
builder.Services.AddDbContext<IdentityContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("IdentityDatabase")));

//Services
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<AuthorizationService>();
builder.Services.AddScoped<SeedService>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<ContactMessageService>();
builder.Services.AddScoped<TagService>();

// Repositories
builder.Services.AddScoped<TagRepository>();
builder.Services.AddScoped<ProductTagRepository>();

//Identity
builder.Services.AddIdentity<IdentityUser, IdentityRole>(x =>
{
    x.SignIn.RequireConfirmedAccount = false;
    x.Password.RequiredLength = 8;
    x.User.RequireUniqueEmail = false;

})
    .AddEntityFrameworkStores<IdentityContext>()
    .AddClaimsPrincipalFactory<CustomClaimsPrincipalFactory>();



var app = builder.Build();
app.UseHsts();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
