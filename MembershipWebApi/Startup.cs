using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;
using Swashbuckle.AspNetCore.Swagger;
using Microsoft.EntityFrameworkCore;
using MembershipWebApi.Models;
using MembershipWebApi.Data;

namespace MembershipWebApi
{
    public class Startup
    {
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services
            //services.AddDbContext<MembershipWebApiContext>(options =>
            //options.UseSqlServer(Configuration.GetConnectionString("MembershipWebApiContext")));
            services.AddSwaggerGen(c => { c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" }); });             
            services.AddMvc();
            //Data Source = CPO - XPS13 - 2\SQLEXPRESS; Initial Catalog = member_management; Integrated Security = False; User Id = members_dev; Password = test123; MultipleActiveResultSets = True"
            //var connection = @"Server=(localdb)\mssqllocaldb;Database=member_management; Integrated Security = False; User Id = members_dev; Password = test123; MultipleActiveResultSets = True";
            services.AddDbContext<DatabaseContext>(options => options.UseSqlServer(Configuration.GetConnectionString("Development")));

            services.AddCors(options =>
            {
                options.AddPolicy("AllowSpecificOrigin",
                    builder => builder.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
            });
            EnableCorsAttribute cors = new EnableCorsAttribute("cors");
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactory.AddDebug();

            app.UseMvc();
            app.UseCors(builder =>
            builder.AllowAnyHeader().AllowAnyOrigin().AllowAnyMethod());
            app.UseCors("AllowSpecificOrigin");

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
