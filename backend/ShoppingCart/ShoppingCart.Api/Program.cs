using Microsoft.EntityFrameworkCore;
using ShoppingCart.Application.Interfaces.Services;
using ShoppingCart.Application.Services;
using ShoppingCart.Domain.Interfaces.Repositories;
using ShoppingCart.Domain.Interfaces.Services;
using ShoppingCart.Domain.Services;
using ShoppingCart.Infra.Context;
using ShoppingCart.Infra.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// DI Context
var connectionString = builder.Configuration.GetConnectionString("MySQLConnection");
builder.Services.AddDbContext<MySQLContext>(options =>
        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// DI Repository
builder.Services.AddTransient<IProductRepository, ProductRepository>();

// DI Domain Service
builder.Services.AddTransient<IProductService, ProductService>();

// DI Application Service
builder.Services.AddTransient<IProductServiceApp, ProductServiceApp>();

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
