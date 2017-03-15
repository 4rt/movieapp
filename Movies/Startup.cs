using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Movies.Models;
using Newtonsoft.Json.Serialization;
using Movies.Services;

namespace Movies
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            //Register and Define a Policy
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });

            services.AddMvc().
                AddJsonOptions(config =>
                {
                    //camecalse json response
                    config.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                });
            //add movie repository one per request for repository pattern
            services.AddScoped<IMoviesRepository, MoviesRepository>();
            services.AddScoped<ICategoriesService, CategoriesService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {

            //Apply the Policy
            app.UseCors("CorsPolicy");

            app.UseMvc();
        }
    }
}
