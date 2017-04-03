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
                    Title = "The Godfather",
                    Plot = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                    Year = 1972,
                    Rating = 9.2,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BZTRmNjQ1ZDYtNDgzMy00OGE0LWE4N2YtNTkzNWQ5ZDhlNGJmL2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNjU0OTQ0OTY@._V1_SX300.jpg",
                    CategoryId = Category5.Id
                };

                var Movie2 = new Movie()
                {
                    Title = "Rogue One",
                    Plot = "The Rebel Alliance makes a risky move to steal the plans for the Death Star, setting up the epic saga to follow.",
                    Year = 2016,
                    Rating = 8.1,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMjEwMzMxODIzOV5BMl5BanBnXkFtZTgwNzg3OTAzMDI@._V1_SX300.jpg",
                    CategoryId = Category1.Id,
                };
                var Movie3 = new Movie()
                {
                    Title = "Ex Machina",
                    Plot = "A young programmer is selected to participate in a ground-breaking experiment in synthetic intelligence by evaluating the human qualities of a breath-taking humanoid A.I.",
                    CategoryId = Category3.Id,
                    Year = 2015,
                    Rating = 8,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTUxNzc0OTIxMV5BMl5BanBnXkFtZTgwNDI3NzU2NDE@._V1_SX300.jpg"
                };
                var Movie4 = new Movie()
                {
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    Plot = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle Earth from the Dark Lord Sauron.",
                    CategoryId = Category1.Id,
                    Year = 2001,
                    Rating = 10,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BNmFmZDdkODMtNzUyMy00NzhhLWFjZmEtMGMzYjNhMDA1NTBkXkEyXkFqcGdeQXVyNDUyOTg3Njg@._V1_SX300.jpg"
                };
                var Movie5 = new Movie()
                {
                    Title = "Interstellar",
                    Plot = "A team of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                    CategoryId = Category3.Id,
                    Year = 2014,
                    Rating = 8.6,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMjIxNTU4MzY4MF5BMl5BanBnXkFtZTgwMzM4ODI3MjE@._V1_SX300.jpg"
                };
                var Movie6 = new Movie()
                {
                    Title = "The Prestige",
                    Plot = "Two stage magicians engage in competitive one-upmanship in an attempt to create the ultimate stage illusion.",
                    CategoryId = Category3.Id,
                    Year = 2006,
                    Rating = 8.5,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMjA4NDI0MTIxNF5BMl5BanBnXkFtZTYwNTM0MzY2._V1_SX300.jpg"
                };
                var Movie7 = new Movie()
                {
                    Title = "2001: A Space Odyssey",
                    Plot = "Humanity finds a mysterious, obviously artificial object buried beneath the Lunar surface and, with the intelligent computer H.A.L. 9000, sets off on a quest.",
                    CategoryId = Category3.Id,
                    Year = 1968,
                    Rating = 8.3,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTZkZTBhYmUtMTIzNy00YTViLTg1OWItNGUwMmVlN2FjZTVkXkEyXkFqcGdeQXVyNDYyMDk5MTU@._V1_SX300.jpg"
                };
                var Movie8 = new Movie()
                {
                    Title = "Metropolis",
                    Plot = "In a futuristic city sharply divided between the working class and the city planners, the son of the city's mastermind falls in love with a working class prophet who predicts the coming of a savior to mediate their differences.",
                    CategoryId = Category3.Id,
                    Year = 1927,
                    Rating = 8.3,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BNDAzNTkyODg1MF5BMl5BanBnXkFtZTgwMDA3NDkwMDE@._V1_SX300.jpg"
                };
                var Movie9 = new Movie()
                {
                    Title = "Beauty and the Beast",
                    Plot = "A young woman whose father has been imprisoned by a terrifying beast offers herself in his place, unaware that her captor is actually a prince, physically altered by a magic spell.",
                    CategoryId = Category6.Id,
                    Year = 1991,
                    Rating = 8,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMzE5MDM1NDktY2I0OC00YWI5LTk2NzUtYjczNDczOWQxYjM0XkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg"
                };
                var Movie10 = new Movie()
                {
                    Title = "Ghost in the Shell",
                    Plot = "A cyborg policewoman and her partner hunt a mysterious and powerful hacker called the Puppet Master.",
                    CategoryId = Category6.Id,
                    Year = 1995,
                    Rating = 8,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BM2FhYzVkMzQtOTVlYS00NTYxLThjNzktMDVhNjU1MDE0ZTc5L2ltYWdlL2ltYWdlXkEyXkFqcGdeQXVyNTAyODkwOQ@@._V1_SX300.jpg"
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
