using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Movies.Models;
using Movies.Services;
using Movies.ViewModels;
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
        
        [HttpGet("api/movies")]
        public IActionResult Get()
        {

            try
            {    
                
                var Movies = _mapper.Map<IEnumerable<MovieDto>>(_data.GetAllMovies());

                return Ok(Movies);

            }
            catch (Exception) {

                return BadRequest("Error");

            }

        }

        [HttpGet("api/movies/categories")]
        public IActionResult GetCategories()
        {

            try
            {
                var categoryWithCounter = _mapper.Map<IEnumerable<CategoryDto>>(_data.GetAllCategories());

                return Ok(categoryWithCounter);
            }
            catch (Exception) {
                return BadRequest("Error");
            }

        }
        
        [HttpGet("api/movies/{id}")]
        public IActionResult GetMovie(int Id)
        {
            try
            {
                var movie = _mapper.Map<MovieDto>(_data.GetMovie(Id));

                return Ok(movie);
            }
            catch (Exception)
            {
                return BadRequest("Error");
            }

        }

        [HttpGet("/api/movies/categoried/{category}")]
        public IActionResult CategoriedMovie(string category)
        {
            try
            {
                var categoriedMovie = _mapper.Map<IEnumerable<MovieDto>>(_movieService.CategoriedMovie(category));

                return Ok(categoriedMovie);
            }
            catch (Exception)
            {
                return BadRequest("Error");
            }
        }

        [HttpPost("api/movies")]
        public async Task<IActionResult> Post([FromBody]MovieDto movie)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var postMovie = _mapper.Map<Movie>(movie);
                    _data.AddMovie(postMovie);

                    if (await _data.SaveChangesAsync())
                    {
                        return Created($"api/movies/{movie.Title}", _mapper.Map<MovieDto>(postMovie));
                    }
                    else
                    {
                    return BadRequest("Failed to save");
                    }
                }
                catch (Exception ex)
                {
                    return BadRequest(ex);
                }
            }

            return BadRequest(ModelState);
        }
    }
}
