using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace WebApplication1
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews(); //MVC
           // services.AddRazorPages(); // Razor
          // services.AddControllers (); //Web APIs
          //  services.AddMvc(); // mix between three project (mvc ,razor ,web APIS)
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles(); //Get File of Resources [Css, JS , Images] 

            app.UseRouting(); // MiddleWare (8 BuiltIN)

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
                //id will became optional
                //endpoints.MapGet("/{controller}/{action}/{ID?:int}", async context =>
                //{
                //    await context.Response.WriteAsync("This is movie number : {ElBremo}");
                //});
                endpoints.MapControllerRoute(
                   name: "Default",
                   pattern :"{controller=Movies}/{action}/{id:int?}"       
                    );
            });
        }
    }
}
