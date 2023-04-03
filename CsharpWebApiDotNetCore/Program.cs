// Giovanni Shaquille Kamta s1172685


using CsharpWebApiDotNetCore.Controllers;
using CsharpWebApiDotNetCore.Data;
using CsharpWebApiDotNetCore.Repositories;
using CsharpWebApiDotNetCore.Services;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AirDBContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AirDBContext") ?? throw new InvalidOperationException("Connection string 'AirDBContext' not found.")));
// Add services to the container.

builder.Services.AddScoped<ILocationService, LocationService>();
//builder.Services.AddScoped<ILocationService, LocationService>();
//builder.Services.AddScoped<ILocationRepository, LocationRepository>();
builder.Services.AddScoped<ILocationRepository, LocationRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(options => options.AllowAnyHeader().AllowAnyOrigin());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
