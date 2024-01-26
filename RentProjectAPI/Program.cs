global using RentProjectAPI.Models;
global using RentProjectAPI.Data;
global using RentProjectAPI.Services;
using RentProjectAPI.Services.CustomerService;
using RentProjectAPI.Services.BirimService;
using RentProjectAPI.Services.CariService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IBirimService, BirimService>();
builder.Services.AddScoped<ICariService, CariService>();

builder.Services.AddDbContext<DataContext>();

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
