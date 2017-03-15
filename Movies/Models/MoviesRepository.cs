using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class MoviesRepository : IMoviesRepository
    {
        private MockData _mockData;
        public MoviesRepository()
        {
            _mockData = new MockData();
        }

        public IEnumerable<Movie> GetAllMovies()
        {
            return _mockData.Movies;
        }

        public IEnumerable<Category> GetAllCategories()
        {
            return _mockData.Categories;
        }

        public Movie GetMovie(int Id)
        {
            return _mockData.Movies
                .Where(t => t.Id == Id)
                .FirstOrDefault();
        }
    }
}
