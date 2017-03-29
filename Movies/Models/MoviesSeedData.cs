using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Movies.Models
{
    public class MoviesSeedData
    {
        private DataContext _context;

        public MoviesSeedData(DataContext context)
        {
            _context = context;
        }

        public async Task SeedData()
        {
            if (!_context.Movies.Any())
            {
                var Category1 = new Category()
                {
                    Name = "Action"
                };

                var Category2 = new Category()
                {
                    Name = "Comedy"
                };
                var Category3 = new Category()
                {
                    Name = "Drama"
                };

                var Category4 = new Category()
                {
                    Name = "Family"
                };
                var Category5 = new Category()
                {
                    Name = "Crime"
                };

                var Category6 = new Category()
                {
                    Name = "Anime"
                };


                _context.Categories.Add(Category1);
                _context.Categories.Add(Category2);
                _context.Categories.Add(Category3);
                _context.Categories.Add(Category4);
                _context.Categories.Add(Category5);
                _context.Categories.Add(Category6);


                var Movie1 = new Movie()
                {
                    Title = "Batman",
                    Year = 1989,
                    Rating = 5,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTYwNjAyODIyMF5BMl5BanBnXkFtZTYwNDMwMDk2._V1_SX300.jpg",
                    CategoryId = Category1.Id
                };

                var Movie2 = new Movie()
                {
                    Title = "Forgetting Sarah Marshall",
                    Year = 2008,
                    Rating = 7.2,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTYzODgzMjAyM15BMl5BanBnXkFtZTcwMTI3NzI2MQ@@._V1_SX300.jpg",
                    CategoryId = Category2.Id,
                };
                var Movie3 = new Movie()
                {
                    Title = "Ex Machina",
                    CategoryId = Category3.Id,
                    Year = 2015,
                    Rating = 8,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTUxNzc0OTIxMV5BMl5BanBnXkFtZTgwNDI3NzU2NDE@._V1_SX300.jpg"
                };
                var Movie4 = new Movie()
                {
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    CategoryId = Category1.Id,
                    Year = 2001,
                    Rating = 10,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BNmFmZDdkODMtNzUyMy00NzhhLWFjZmEtMGMzYjNhMDA1NTBkXkEyXkFqcGdeQXVyNDUyOTg3Njg@._V1_SX300.jpg"
                };
                var Movie5 = new Movie()
                {
                    Title = "Fast and Furious",
                    CategoryId = Category5.Id,
                    Year = 1939,
                    Rating = 6.2,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMjAyNTQ1NjA3Ml5BMl5BanBnXkFtZTgwOTIyNjIxMzE@._V1_SX300.jpg"
                };
                var Movie6 = new Movie()
                {
                    Title = "Dominator",
                    CategoryId = Category6.Id,
                    Year = 2003,
                    Rating = 4.5,
                    Poster = "http://ia.media-imdb.com/images/M/MV5BMTUyMjI5NDc1MV5BMl5BanBnXkFtZTcwMjMwMjQyMQ@@._V1_SX300.jpg"
                };
                var Movie7 = new Movie()
                {
                    Title = "Confessions of a Shopaholic",
                    CategoryId = Category4.Id,
                    Year = 2009,
                    Rating = 6,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTQ1MzcyMTkwOF5BMl5BanBnXkFtZTcwMDM3MTc5MQ@@._V1_SX300.jpg"
                };
                var Movie8 = new Movie()
                {
                    Title = "Home Alone",
                    CategoryId = Category4.Id,
                    Year = 1990,
                    Rating = 7.5,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BNmQzYjEzYTQtNzNhZi00NmEwLThiZDMtMWYyNjRmZWY0ZTdkXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg"
                };
                var Movie9 = new Movie()
                {
                    Title = "Weekend at Bernie's",
                    CategoryId = Category4.Id,
                    Year = 1989,
                    Rating = 6.3,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMjAwMjU1MTA4N15BMl5BanBnXkFtZTcwNzAxNTc3NA@@._V1_SX300.jpg"
                };
                var Movie10 = new Movie()
                {
                    Title = "James Bond",
                    CategoryId = Category1.Id,
                    Year = 1999,
                    Rating = 5.0,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BOTJlYWYyMTUtNzQ2YS00YmYzLThkMzItOGQ0ZDA0ZWJhNjFkXkEyXkFqcGdeQXVyMjkxNzQ1NDI@._V1_SX300.jpg"
                };



                _context.Movies.Add(Movie1);
                _context.Movies.Add(Movie2);
                _context.Movies.Add(Movie3);
                _context.Movies.Add(Movie4);
                _context.Movies.Add(Movie5);
                _context.Movies.Add(Movie6);
                _context.Movies.Add(Movie7);
                _context.Movies.Add(Movie8);
                _context.Movies.Add(Movie9);
                _context.Movies.Add(Movie10);

                await _context.SaveChangesAsync();

            }
        }
    }
}
