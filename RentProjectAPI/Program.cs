global using RentProjectAPI.Models;
global using RentProjectAPI.Data;
global using RentProjectAPI.Services;
using RentProjectAPI.Services.CustomerService;
using RentProjectAPI.Services.BirimService;
using RentProjectAPI.Services.CariService;
using RentProjectAPI.Services.DepoService;
using RentProjectAPI.Services.DövizService;
using RentProjectAPI.Services.HareketService;
using RentProjectAPI.Services.ÝadeService;
using RentProjectAPI.Services.KasaService;
using RentProjectAPI.Services.KategorilerService;
using RentProjectAPI.Services.KullaniciService;
using RentProjectAPI.Services.PcMasterService;
using RentProjectAPI.Services.PcPosMasterService;
using RentProjectAPI.Services.StokService;
using RentProjectAPI.Services.UrunlerService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<ICustomerService, CustomerService>();
builder.Services.AddScoped<IBirimService, BirimService>();
builder.Services.AddScoped<ICariService, CariService>();
builder.Services.AddScoped<IDepoService, DepoService>();
builder.Services.AddScoped<IDövizService, DövizService>();
builder.Services.AddScoped<IHareketService, HareketService>();
builder.Services.AddScoped<IÝadeService, ÝadeService>();
builder.Services.AddScoped<IKasaService, KasaService>();
builder.Services.AddScoped<IKategorilerService, KategorilerService>();
builder.Services.AddScoped<IKullaniciService, KullaniciService>();
builder.Services.AddScoped<IPcMasterService, PcMasterService>();
builder.Services.AddScoped<IPcPosMasterService, PcPosMasterService>();
builder.Services.AddScoped<IStokService, StokService>();
builder.Services.AddScoped<IUrunlerService, UrunlerService>();

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
