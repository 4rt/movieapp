using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Movies.Models
{
    public class DataContext : DbContext
    {
        private IConfigurationRoot _config;

        public DataContext(IConfigurationRoot config, DbContextOptions options) : base (options)
        {
            _config = config;
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(_config["ConnectionStrings:MovieContextConnection"]);
        }
    }
}
