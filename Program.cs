using BlazorServerAppBanco.Models;
using BlazorServerAppBanco.Services;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
//builder.Services.AddSingleton<WeatherForecastService>();

// Configurar AutoMapper
builder.Services.AddAutoMapper(typeof(Program)); // Esto registra automáticamente todos los perfiles AutoMapper en la aplicación.

//configurar entity framework
builder.Services.AddDbContext<TransactionalBankContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

//inyectar libreria mudblazor
builder.Services.AddMudServices();

//inyectar dependencia de la carpeta services(inyector)
builder.Services.AddScoped<ISecUserService, SecUserService>();
builder.Services.AddScoped<ISecAppService, SecAppService>();
builder.Services.AddScoped<ISecUserGroupService, SecUserGroupService>();
builder.Services.AddScoped<ITagUserService, TagUserService>();
builder.Services.AddScoped<ISecGroupAppService, SecGroupAppService>();

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

//crear contexto a partir de la BD
//dotnet ef dbcontext scaffold "Host=localhost;Database=transactional_bank;Username=postgres;Password=12345" Npgsql.EntityFrameworkCore.PostgreSQL

//actualizar la BD
//dotnet ef dbcontext scaffold "Host=localhost;Database=transactional_bank;Username=postgres;Password=12345" Npgsql.EntityFrameworkCore.PostgreSQL --output-dir /Models --force
