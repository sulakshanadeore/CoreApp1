
using CoreApp1.Models;
using Microsoft.Extensions.DependencyInjection;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();
        builder.Services.AddSession(options => { options.IdleTimeout = TimeSpan.FromMinutes(1); });

        builder.Services.AddSingleton(typeof(ICategoryRepository),new CategoryRepository());

        //cartdata----->Scoped
        builder.Services.AddTransient<IFirst,Greeting>();
        builder.Services.AddScoped<IFirst, Greeting>();







        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        //Working with middlewares
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseSession();
        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}