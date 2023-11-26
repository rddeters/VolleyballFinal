using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using VolleyballFinal.Models;
using VolleyballFinal.Models.Admin;

namespace VolleyballFinal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddIdentity<User, IdentityRole>().AddEntityFrameworkStores<TeamContext>().AddDefaultTokenProviders();

            builder.Services.AddDbContext<TeamContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("TeamContext")));
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
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

            app.Run();
        }
    }
}
