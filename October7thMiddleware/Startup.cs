using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using October7thMiddleware.Middleware;

namespace October7thMiddleware
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

            app.UseAuthentication();
            app.UseAuthorization();

            app.Use(async (context, next) =>
            {
                //Logic to perform on the request
                await context.Response.WriteAsync("<p> This is MiddleWare 1 </p>");
                await next();
                //Logic to perform on the response
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<p> This is MiddleWare 2 </p>");
                await next();
            });

            app.UseMiddleware<ExceptionHandlingMiddleware>();

            app.Map("/darion", action =>
            {
                action.Use(async (context, next) =>
                {
                    await context.Response.WriteAsync("<p> Darion likes middleware !!!! </p>");
                    await next();
                });

                action.Use(async (context, next) =>
                {
                    await context.Response.WriteAsync("<p> Bernard likes middleware 2 !!!! </p>");
                    await next();
                });
            });

            app.Use(async (context, next) =>
            {
                await context.Response.WriteAsync("<p> This is the Run middleware </p>");
                await next();
            });

            

        }
    }
}
