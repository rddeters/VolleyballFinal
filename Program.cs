using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using VolleyballFinal.Models;
using VolleyballFinal.Models.Admin;
using Microsoft.Extensions.Configuration;
using VolleyballFinal.Controllers.Service;

namespace VolleyballFinal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<TeamContext>().AddDefaultTokenProviders();

            builder.Services.AddDbContext<TeamContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("TeamContext")));

            builder.Services.AddScoped<TeamService>();
            builder.Services.AddScoped<PlayerService>();
            builder.Services.AddScoped<StatisticService>();

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            else
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "teamRoute",
                pattern: "{controller=Team}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "playerRoute",
                pattern: "{controller=Player}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "adminRoute",
                pattern: "{controller=Admin}/{action=LogIn}");

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.Run();
        }
    }
}
