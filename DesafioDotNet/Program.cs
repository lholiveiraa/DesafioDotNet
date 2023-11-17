using DesafioDotNet.API;
using DesafioDotNet.Domain;
using DesafioDotNet.Domain.Interfaces;
using DesafioDotNet.Domain.Model;
using DesafioDotNet.Infrastructure.Context;
using DesafioDotNet.Infrastructure.Repositories;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DesafioDotNetDbContext>(options =>
               options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(IRepository<Pedido>),typeof(PedidoRepository));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


//builder.Services.AddScoped<IPedidoRepository, PedidoRepository>();
//builder.Services.AddScoped<IPedidoAppService, PedidoAppService>();

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



////services.AddScoped<IPedidoRepository, PedidoRepository>(); 
//services.AddScoped<IPedidoAppService, PedidoAppService>();

//// Configuração do AutoMapper
//services.AddAutoMapper(typeof(Startup), typeof(MappingProfile));