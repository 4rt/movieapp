using Movies.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Services
{
    public class CategoriesService: ICategoriesService
    {
        private IMoviesRepository _repository;

        public CategoriesService(IMoviesRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<Movie> CategoriedMovie(string Categories)
        {

            var testCategories = Categories.Contains(",");

            var allMovies = _repository.GetAllMovies();

            if (Categories == null) {
                return allMovies;
            }
            else {
                if (testCategories)
                {
                    var categories = Categories.Split(',');

                    var multipleFiltered = allMovies.Where(movie => categories.Any(category => category == movie.Category.Name));

                    return multipleFiltered;
                }
                else {
                    var filtered = allMovies.Where(t => t.Category.Name == Categories);

                    return filtered;
                }
            }
             
        }

    }
}
