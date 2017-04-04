using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class MoviesRepository : IMoviesRepository
    {
        private DataContext _context;

        public MoviesRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _context.Movies
                .Include("Category")
                .ToList();
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _context.Categories
                .Include("Movies")
                .ToList();
        }

        public Movie GetMovie(int Id)
        {
            return _context.Movies
                .Include("Category")
                .Where(t => t.Id == Id)
                .FirstOrDefault();
        }
    }
}
