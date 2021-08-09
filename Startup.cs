using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Back_end.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Back_end
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // Here we add external services.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddDbContext<airecommerceContext>();
            services.AddCors();
            //services.AddControllers();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        // Here we add middlewares to the pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            /* else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }*/
            // we'll not be using https
            // app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            // Here is the CORS policy, we will allow any method from the origin
            // that we have in the reactjs web page.
            app.UseCors(configPolicy =>
            {
                configPolicy.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader();
            });

            app.UseAuthorization();

            // Now we have to configure the endpoints we will serve
            // We'll be using attribute routing instead of convention routing
            // That's why we use MapControllers instead of MapControllerRoute
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
