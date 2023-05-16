using locacaoFilmes.Domain.Contracts.v1.Repository;
using locacaoFilmes.Domain.Contracts.v1.Service;
using locacaoFilmes.Domain.Entity.v1;
using locacaoFilmes.Domain.Services;
using locacaoFilmes.Infra.SqlServer.Context.v1;
using locacaoFilmes.Infra.SqlServer.Repositories.v1;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
builder.Services.AddControllersWithViews();

var services = builder.Services;


services.AddControllers();

services.AddTransient<ApplicationContext>();

services.AddTransient<IClienteService, ClienteService>();
services.AddTransient<IClienteRepository, ClienteRepository>();

services.AddTransient<IFilmeService, FilmeService>();
services.AddTransient<IFilmeRepository, FilmeRepository>();

services.AddTransient<ILocacaoService, LocacaoService>();
services.AddTransient<ILocacaoRepository, LocacaoRepository>();

services.AddTransient<IUsuarioService, UsuarioService>();
services.AddTransient<IUsuarioRepository, UsuarioRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
     name: "clientes",
     pattern: "Locacao/{action=Index}/{id?}",
     defaults: new { controller = "Locacao" });

app.Run();
