using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace Riviera_Business
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

            services.AddSession( options=> {
                options.IdleTimeout = TimeSpan.FromDays(1);
            });

            services.AddControllersWithViews();

            services.AddAuthentication("PKAT")
                .AddCookie("PKAT", options => {
                    options.ReturnUrlParameter = "returnURL";
                    options.ExpireTimeSpan = TimeSpan.FromHours(8);
                    options.LoginPath = "/Login_/Index";
                    options.LogoutPath = "/Login/Logout";
                });

            services.Add(new ServiceDescriptor(typeof(Models.riviera_businessContext),
         new Models.riviera_businessContext(V: Configuration.GetConnectionString("riviera_business"))));
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

            app.UseSession();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Login_}/{action=Index}/{id?}");
            });
        }
    }
}
