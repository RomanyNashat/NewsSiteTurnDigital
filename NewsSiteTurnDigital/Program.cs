using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using NewsSiteTurnDigital.WEB.Auth;
using NewsSiteTurnDigital.WEB.Extensions;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDatabase(builder.Configuration).AddRepositories().AddServices();
builder.Services.AddHttpContextAccessor();
builder.Services.AddControllers(x => x.Filters.Add<CustomAuthorizeAttribute>());

builder.Services.AddAuthentication(
CookieAuthenticationDefaults.AuthenticationScheme
).AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
options =>
{
    options.Cookie.HttpOnly = true;
    options.Cookie.Name = CookieAuthenticationDefaults.AuthenticationScheme;
    options.Cookie.SameSite = SameSiteMode.Lax;
    options.LoginPath = "/Account/Login";
    options.LogoutPath = "/Account/Logout";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(10);

});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

//endpoints.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Account}/{action=Login}/{id?}");

app.MapControllers().RequireAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}");


//pattern: "{controller=Home}/{action=Index}/{id?}");
app.MigrateDatabase();
app.Run();
