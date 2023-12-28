using FoodApplication.ContextDBConfig;
using FoodApplication.Models;
using FoodApplication.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace FoodApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var dbconnectoin = builder.Configuration.GetConnectionString("dbConnection");

            // Add services to the container.

            builder.Services.AddControllersWithViews();
            //  builder.Services.AddDbContext<FoodApplicationDB>(options =>
            //options.UseSqlServer(dbconnectoin));

            //builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
            //   .AddEntityFrameworkStores<FoodApplicationDB>();

            var app =builder.Build();
           
            

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

            app.Run();
        }
    }
}
