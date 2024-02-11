using Microsoft.Extensions.Configuration;
using ZeroFramework.Application.Common;
using ZeroFramework.Application;
using AccountManagment.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddHttpContextAccessor();
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
AccountManagementBootstrapper.Configure(builder.Services, connectionString);

builder.Services.AddTransient<IAuthHelper, AuthHelper>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
