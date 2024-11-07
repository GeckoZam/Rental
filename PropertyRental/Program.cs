using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Configura los servicios de MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configura el pipeline de la aplicación
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Configuración de la ruta predeterminada
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Properties}/{action=CreateBooking}/{id?}");

app.Run();
