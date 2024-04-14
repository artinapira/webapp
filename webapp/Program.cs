using Microsoft.EntityFrameworkCore;
using System;
using webapp;
using webapp.Models;
using webapp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ClinicDbContext>(options =>
options.UseSqlServer("DentalClinicDatabase"));

builder.Services.AddTransient<PacientiService>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
AppDbInitializer.Seed(app);

app.Run();

