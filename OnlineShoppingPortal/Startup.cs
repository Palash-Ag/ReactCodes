using DocumentFormat.OpenXml.Bibliography;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using OnlineShoppingPortal.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShoppingPortal
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
            services.AddControllers();
            services.AddDbContext<StoreContext>(options =>
            options.UseSqlServer(Configuration.GetConnectionString("SqlConnectionString")));
            services.AddCors(options =>
            {
                options.AddPolicy(name: "MyAllowSpecificOrigins",
                                  policy =>
                                  {
                                      policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:3000");
                                  });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles(new StaticFileOptions
            {
                FileProvider = new PhysicalFileProvider(
           Path.Combine(env.ContentRootPath, "courseAssets")),
                RequestPath = "/StaticFiles"
            });

            app.UseRouting();
            app.UseCors("MyAllowSpecificOrigins");
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
