using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _portfolio.Data;
using _portfolio.Data.interfaces;
using _portfolio.Data.mocks;
using _portfolio.Data.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace _portfolio
{
    public class Startup
    {
        private readonly IConfiguration Configuration;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<DatabaseContext>(options => options.UseSqlite(Configuration.GetConnectionString("sqlite")));
            services.AddTransient<IExamples, ExampleRepository>();
            services.AddMvc(options => options.EnableEndpointRouting = false);
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            using(var scoupe = app.ApplicationServices.CreateScope())
            {
                DatabaseContext context = scoupe.ServiceProvider.GetRequiredService<DatabaseContext>();
                DBObjects.Initial(context);
            }
        }
    }
}
