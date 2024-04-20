using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MusicOrganizer.Models;

namespace MusicOrganizer.Models
{
    public class Program
    {
        public static void Main(string[] args)
        {
            WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
            
            builder.Services.AddControllersWithViews();
            
            WebApplication app = builder.Build();

            app.UseStaticFiles();
            app.UseHttpsRedirection();
            app.UseRouting();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );

            app.Run();

        }
    }    
}