using AutoMapper;
using BlazorServerAppBanco.Data;
using BlazorServerAppBanco.Models;
using BlazorServerAppBanco.ModelsDTO;
using BlazorServerAppBanco.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

// Configurar AutoMapper
builder.Services.AddAutoMapper(typeof(Program)); // Esto registra autom�ticamente todos los perfiles AutoMapper en la aplicaci�n.

//configurar entity framework
builder.Services.AddDbContext<TransactionalBankContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

//inyectar dependencia de la carpeta services(inyector)
builder.Services.AddScoped<ISecUserService, SecUserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseSwagger();
//app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();