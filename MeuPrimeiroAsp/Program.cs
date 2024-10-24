using MeuPrimeiroAsp.Data;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Adiciona o contexto do banco de dados ao contêiner de serviços
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("strConn")));

//Adicionar cookie para armazenar dados usuario
builder.Services
    .AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie((options) =>
    {
        options.LoginPath = "/Login";
    });

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

app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "Home.Index",
    pattern: "",
    defaults: new { controller = "Home", action = "Index" });
app.MapControllerRoute(
    name: "Usuario.Cadastro",
    pattern: "Cadastro Usuario",
    defaults: new { controller = "Usuario", action = "Cadastro" });
app.MapControllerRoute(
    name: "Usuario.Login",
    pattern: "Login",
    defaults: new { controller = "Usuario", action = "Login" });
app.MapControllerRoute(
    name: "Usuario.Logout",
    pattern: "Logout",
    defaults: new { controller = "Usuario", action = "Logout" });

app.Run();


app.Run();
