using CRUDPRACTICAL.Controllers;
using CRUDPRACTICAL.Models;
using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentFormat.OpenXml.Presentation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using NHibernate.SqlCommand;
using ReflectionIT.Mvc.Paging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CRUDPRACTICAL
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        [Obsolete]
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
            services.AddDbContext<EmployeeContext>(options=>
            options.UseSqlServer(Configuration.GetConnectionString("DevConnection")));


            //services.Configure<MvcRazorRuntimeCompilationOptions>(options => {
            //    options.FileProviders.Clear();
            //    options.FileProviders.Add(new PhysicalFileProvider(appDirectory));
            //});

            services.Configure<Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation.MvcRazorRuntimeCompilationOptions>(options =>
            {
                options.FileProviders.Add(
                new EmbeddedFileProvider(typeof(EmployeeController).GetTypeInfo().Assembly));
            });

            // Requires using System.Reflection;
            var assembly = typeof(EmployeeController).GetTypeInfo().Assembly;
            services.AddMvc().AddRazorRuntimeCompilation()
                            .AddApplicationPart(assembly)
                            .SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            //services.AddPaging();

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
            app.UseAuthentication();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            /*  app.UseEndpoints(endpoints =>
              {
                  endpoints.MapControllerRoute(
                      name: "default",
                     // pattern: "{controller=Home}/{action=Index}/{id?}");
                      pattern: "{controller=Employee}/{action=Index}/{id?}");


          });*/
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Employee}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "Employee",
                    pattern: "{controller=Employee}/{action=Create}/{id?}");

                endpoints.MapControllerRoute(
                   name: "Edit",
                   pattern: "{controller=Employee}/{action=Edit}/{id?}");

                endpoints.MapControllerRoute(
                   name: "Delete",
                   pattern: "{controller=Employee}/{action=Delete}/{id?}");


                endpoints.MapControllerRoute(
                   name: "Login",
                   pattern: "{controller=Login}/{action=Login}/{id?}");

            }); 



            /*  app.UseEndpoints(endpoints =>
             {
                 endpoints.MapControllerRoute(
                     name: "Edit",
                    // pattern: "{controller=Home}/{action=Index}/{id?}");
                     pattern: "{controller=Employee}/{action=Edit}/{id?}");


         });*/
        }
    }
}
