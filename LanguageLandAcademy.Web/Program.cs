using AccountManagment.Configuration;
using LanguageLandAcademy.Web;
using ManagmentSystem.Configuration;
using Microsoft.AspNetCore.Authentication.Cookies;
using ZeroFramework.Application;
using ZeroFramework.Application.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var con = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddHttpContextAccessor();

//bootstrappers
ManagmentSystemBootstraper.Configure(builder.Services, con);
AccountManagementBootstrapper.Configure(builder.Services, con);

//interfaces and implementions
builder.Services.AddTransient<IAuthHelper, AuthHelper>();
builder.Services.AddSingleton<IPasswordHasher, PasswordHasher>();
builder.Services.AddTransient<IFileUploader, FileUploader>();

builder.Services.Configure<CookiePolicyOptions>(options =>
{
    options.CheckConsentNeeded = context => true;
    options.MinimumSameSitePolicy = SameSiteMode.Lax;
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
               .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme, o =>
               {
                   o.LoginPath = new PathString("/Login");
                   o.LogoutPath = new PathString("/Login");
                   o.AccessDeniedPath = new PathString("/AccessDenied");
               });

builder.Services.AddAuthorization
    (options =>
    {
        options.AddPolicy("AdminArea", builder => builder.RequireRole("1"));

        //options.AddPolicy("Login", builder => builder.RequireRole());


    });

builder.Services.AddRazorPages(options =>
{
    options.Conventions.
    AuthorizeAreaFolder("Administration", "/", "AdminArea");

//    options.Conventions.
//AuthorizeAreaFolder("Administration", "/Login", "Login");

});

var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseAuthentication();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseCookiePolicy();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
