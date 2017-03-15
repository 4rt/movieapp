using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public interface IMoviesRepository
    {
        IEnumerable<Movie> GetAllMovies();
        IEnumerable<Category> GetAllCategories();
        Movie GetMovie(int Id);
    }
}
