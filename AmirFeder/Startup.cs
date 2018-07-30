using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmirFeder.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AmirFeder
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // Granting access to services provice by EF Core
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration["Data:AmirFederDb:ConnectionString"]));
            services.AddTransient<IRepository, EFRepository>(); // Adding repository
            services.AddMvc();
        }

       
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            
            app.UseDeveloperExceptionPage(); // Views detail information about the error // ONLY FOR DEVELOPER
            app.UseStatusCodePages();        // It's adding a simple communication to HTTP answer
            app.UseStaticFiles();            // For static files like bootstrap etc. located in /wwwroot
            app.UseMvc(routes =>             // Turn on ASP.NET CORE MVC
            {
                routes.MapRoute(
                    name: null,
                    template: "{category}",
                    defaults: new { controller = "Product", action="List" }
                    );

                routes.MapRoute(             
                    name: null,
                    template: "{controller=Product}/{action=List}/{id?}");
            });
            // Add initial data to the db
            SeedData.EnsurePopulated(app);

        }
    }
}
