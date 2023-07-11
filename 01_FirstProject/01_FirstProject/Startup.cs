using _01_FirstProject.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            // Thay hàm OnConfiguring trong file firstNetCoreProjectContext.cs
            var connectionString = Configuration.GetConnectionString("firstNetCoreProjectDatabase");
            services.AddDbContext<firstNetCoreProjectContext>(options => options.UseSqlServer(connectionString));
       
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //https://localhost:44393/News
                //https://localhost:44393/BinhNews

                endpoints.MapControllerRoute(
                   name: "Sercure",
                   pattern: "Sercure",
                   new { controller = "Admin", action = "Index" });

                endpoints.MapControllerRoute(
                   name: "News",
                   pattern: "BinhNews",
                   new { controller = "News", action = "Index" });

                endpoints.MapControllerRoute(
                 name: "Users",
                 pattern: "Users",
                 new { controller = "Users", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "Home",
                    pattern: "{Home}",
                    new { controller = "Home", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
