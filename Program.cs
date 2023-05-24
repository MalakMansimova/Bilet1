using Bilet_1Project.DAL;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bilet_1Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<AddDbContext>(options =>
            {
                //options.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
                options.UseSqlServer(builder.Configuration["ConnectionStrings:Default"]);

            });
            var app = builder.Build();
       
            app.UseStaticFiles();
            app.UseRouting();
            //app.UseAuthentication();
            //app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });

            app.Run();
        }
    }
}