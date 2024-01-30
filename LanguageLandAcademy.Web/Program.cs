using AccountManagment.Configuration;
using LanguageLandAcademy.Web;
using ManagmentSystem.Configuration;
using ZeroFramework.Application;
using ZeroFramework.Application.Common;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var con = builder.Configuration.GetConnectionString("DefaultConnection");

ManagmentSystemBootstraper.Configure(builder.Services, con);
AccountManagementBootstrapper.Configure(builder.Services, con);

//builder.Services.AddTransient<IAuthHelper, AuthHelper>();
builder.Services.AddSingleton<IPasswordHasher, PasswordHasher>();
builder.Services.AddTransient<IFileUploader, FileUploader>();

var app = builder.Build();





// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
