using CookbookService.Domain;
using CookbookService.Domain.Options;
using CookbookService.Infrastrructure.Abstractions;
using CookbookService.Infrastrructure.EntityFramework;
using CookbookService.Infrastrructure.LiteDb;
using MediatR;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.Configure<LiteDbOptions>(configuration.GetSection(LiteDbOptions.NodeName));

// Add services to the container.
builder.Services.AddControllers();
//builder.Services.AddDbContext<DatabaseContext>();
builder.Services.AddSingleton<IRepository<MenuEntity>, LiteDbContext<MenuEntity>>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

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
