using EntityFrameworkApi.Context;
using EntityFrameworkApi.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using AutoMapper;
using EntityFrameworkApi.Services;
using EntityFrameworkApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<TestContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"),
     sqlServerOptionsAction: builder =>
     {
         builder.EnableRetryOnFailure(
             maxRetryCount: 10,
             maxRetryDelay: TimeSpan.FromSeconds(30),
             errorNumbersToAdd: null);
     }));
builder.Services.AddTransient<IDevelopersRepository, DevelopersRepository>();
builder.Services.AddTransient<IDevelopersServices, DevelopersServices>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

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
