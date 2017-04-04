using AutoMapper;
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
        private IMapper _mapper;

        public MoviesController(IMoviesRepository repository, ICategoriesService movieservice, IMapper mapper)
        {
            _data = repository;
            _movieService = movieservice;
            _mapper = mapper;
        }

        //handle http GET request on api/movies url (return list of movies)
        [HttpGet("api/movies")]
        public IActionResult Get()
        {
            var Movies = _mapper.Map<IEnumerable<MovieDto>>(_data.GetAllMovies());

            return Ok(Movies);

        }

        [HttpGet("api/movies/categories")]
        public IActionResult GetCategories()
        {
            var categoryWithCounter = _mapper.Map<IEnumerable<CategoryDto>>(_data.GetAllCategories());

            return Ok(categoryWithCounter);
        }

        //handle http GET request on api/movies/{1} url (return movie by id)
        [HttpGet("api/movies/{id}")]
        public IActionResult GetMovie(int Id)
        {
            //var movie = _data.GetMovie(Id);
            var movie = _mapper.Map<MovieDto>(_data.GetMovie(Id));

            return Ok(movie);
        }

        //handle http GET request on /api/movies/categoried/[categories] url(return movie by categories)
        [HttpGet("/api/movies/categoried/{category}")]
        public IActionResult CategoriedMovie(string category)
        {
            //var categoriedMovie = _movieService.CategoriedMovie(category);
            var categoriedMovie = _mapper.Map<IEnumerable<MovieDto>>(_movieService.CategoriedMovie(category));

            return Ok(categoriedMovie);
        }
    }
}
