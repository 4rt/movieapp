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
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Cors.Infrastructure;
using AutoMapper;
using Movies.ViewModels;

namespace Movies
{
    public class Startup
    {
        private IConfigurationRoot _config;
        private IHostingEnvironment _env;

        public Startup(IHostingEnvironment env)
        {
            _env = env;

            var builder = new ConfigurationBuilder()
              .SetBasePath(_env.ContentRootPath)
              .AddJsonFile("config.json")
              .AddEnvironmentVariables();

            _config = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton(_config);

            var cfg = new MapperConfiguration(conf =>
            {
                conf.CreateMap<Category, CategoryDto>().ForMember(
                    dest => dest.Counter,
                    opt => opt.MapFrom(src => src.Movies.Count)
                );
                conf.CreateMap<Movie, MovieDto>().ForMember(dest => dest.Poster, opt => opt.MapFrom(src => string.IsNullOrEmpty(src.Poster) ? "assets/img/noimage.jpg" : src.Poster )).ReverseMap()
                .ForMember(dest => dest.Category, opt => opt.Ignore());
            });

            cfg.AssertConfigurationIsValid();
            var mapper = cfg.CreateMapper();

            var corsBuilder = new CorsPolicyBuilder();
            corsBuilder.AllowAnyHeader();
            corsBuilder.AllowAnyMethod();
            corsBuilder.AllowAnyOrigin();
            corsBuilder.AllowCredentials();
            services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", corsBuilder.Build());
            });

            services.AddDbContext<DataContext>();

            services.AddTransient<MoviesSeedData>();

            services.AddSingleton(mapper);

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
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, MoviesSeedData seedData)
        {
            app.UseCors("AllowAll");

            app.UseMvc();

            seedData.SeedData().Wait();

            app.UseDeveloperExceptionPage();
        }
    }
}
