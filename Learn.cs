// using Microsoft.AspNetCore.Mvc;
// using Microsoft.Extensions.DependencyInjection;
// using MusicOrganizer.Models;
// using System;


// namespace MusicOrganizer.Models
// {
//     public class Program
//     {
//         public static void Main(string[] args)
//         {
//             WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
//             builder.Services.AddControllersWithViews();

//             WebApplication app = builder.Build();
//             app.UseRouting();
//             app.UseStaticFiles();
//             app.UseHttpsRedirection();

//             app.MapControllerRoute(
//                 name: "{default}",
//                 pattern: "{controller=Home}/{action=Index}/{id?}"
//             );
//             app.Run();

//         }
//     }
// }