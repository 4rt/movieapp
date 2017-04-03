using Microsoft.AspNetCore.Mvc;
using Movies.Models;
using Movies.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Controllers.Api
{
    public class MoviesController : Controller
    {
        private IMoviesRepository _data;
        private ICategoriesService _movieService;

        public MoviesController(IMoviesRepository repository, ICategoriesService movieservice)
        {
            _data = repository;
            _movieService = movieservice;
        }

        //handle http GET request on api/movies url (return list of movies)
        [HttpGet("api/movies")]
        public IActionResult Get()
        {
            return Ok(_data.GetAllMovies());

        }

        [HttpGet("api/movies/categories")]
        public IActionResult GetCategories()
        {
            return Ok(_data.GetAllCategories());
        }

        //handle http GET request on api/movies/{1} url (return movie by id)
        [HttpGet("api/movies/{id}")]
        public IActionResult GetMovie(int Id)
        {
            var movie = _data.GetMovie(Id);

            return Ok(movie);
        }

        //handle http GET request on /api/movies/categoried/[categories] url(return movie by categories)
        [HttpGet("/api/movies/categoried/{category}")]
        public IActionResult CategoriedMovie(string category)
        {
            var categoriedMovie = _movieService.CategoriedMovie(category);

            return Ok(categoriedMovie);
        }
    }
}
