using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Models
{
    public class MockData
    {
        public MockData()
        {
            var category1 = new Category
            {
                Id = 1,
                Name = "Action"
            };
            var category2 = new Category
            {
                Id = 2,
                Name = "Comedy"
            };
            var category3 = new Category
            {
                Id = 3,
                Name = "Drama"
            };
            var category4 = new Category
            {
                Id = 4,
                Name = "Drama"
            };
            var category5 = new Category
            {
                Id = 5,
                Name = "Crime"
            };
            var category6 = new Category
            {
                Id = 6,
                Name = "Animation"
            };
            var category7 = new Category
            {
                Id = 7,
                Name = "Family"
            };
            var category8 = new Category
            {
                Id = 8,
                Name = "Family"
            };
            var category9 = new Category
            {
                Id = 9,
                Name = "Adventure"
            };
            var category10 = new Category
            {
                Id = 10,
                Name = "Action"
            };

            Categories = new List<Category>();

            Categories.Add(category1);
            Categories.Add(category2);
            Categories.Add(category3);
            Categories.Add(category4);
            Categories.Add(category5);
            Categories.Add(category6);
            Categories.Add(category7);
            Categories.Add(category8);
            Categories.Add(category9);
            Categories.Add(category10);

            Movies = new List<Movie>() {
                new Movie
                {
                    Id = 1,
                    Title = "Batman",
                    Category = category1,
                    CategoryId = category1.Id,
                    Year = 1989,
                    Rating = 5,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTYwNjAyODIyMF5BMl5BanBnXkFtZTYwNDMwMDk2._V1_SX300.jpg"
                },
                new Movie
                {
                    Id = 2,
                    Title = "Forgetting Sarah Marshall",
                    Category = category2,
                    CategoryId = category2.Id,
                    Year = 2008,
                    Rating = 7.2,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTYzODgzMjAyM15BMl5BanBnXkFtZTcwMTI3NzI2MQ@@._V1_SX300.jpg"
                },
                new Movie
                {
                    Id = 3,
                    Title = "Ex Machina",
                    Category = category3,
                    CategoryId = category3.Id,
                    Year = 2015,
                    Rating = 8,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTUxNzc0OTIxMV5BMl5BanBnXkFtZTgwNDI3NzU2NDE@._V1_SX300.jpg"
                },
                new Movie
                {
                    Id = 4,
                    Title = "The Lord of the Rings: The Fellowship of the Ring",
                    Category = category4,
                    CategoryId = category4.Id,
                    Year = 2001,
                    Rating = 10,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BNmFmZDdkODMtNzUyMy00NzhhLWFjZmEtMGMzYjNhMDA1NTBkXkEyXkFqcGdeQXVyNDUyOTg3Njg@._V1_SX300.jpg"
                },
                new Movie
                {
                    Id = 5,
                    Title = "Fast and Furious",
                    Category = category5,
                    CategoryId = category5.Id,
                    Year = 1939,
                    Rating = 6.2,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMjAyNTQ1NjA3Ml5BMl5BanBnXkFtZTgwOTIyNjIxMzE@._V1_SX300.jpg"
                },
                new Movie
                {
                    Id = 6,
                    Title = "Dominator",
                    Category = category6,
                    CategoryId = category6.Id,
                    Year = 2003,
                    Rating = 4.5,
                    Poster = "http://ia.media-imdb.com/images/M/MV5BMTUyMjI5NDc1MV5BMl5BanBnXkFtZTcwMjMwMjQyMQ@@._V1_SX300.jpg"
                },
                new Movie
                {
                    Id = 7,
                    Title = "Confessions of a Shopaholic",
                    Category = category6,
                    CategoryId = category6.Id,
                    Year = 2009,
                    Rating = 6,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMTQ1MzcyMTkwOF5BMl5BanBnXkFtZTcwMDM3MTc5MQ@@._V1_SX300.jpg"
                },
                new Movie
                {
                    Id = 8,
                    Title = "Home Alone",
                    Category = category8,
                    CategoryId = category8.Id,
                    Year = 1990,
                    Rating = 7.5,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BNmQzYjEzYTQtNzNhZi00NmEwLThiZDMtMWYyNjRmZWY0ZTdkXkEyXkFqcGdeQXVyMTQxNzMzNDI@._V1_SX300.jpg"
                },
                new Movie
                {
                    Id = 9,
                    Title = "Weekend at Bernie's",
                    Category = category9,
                    CategoryId = category9.Id,
                    Year = 1989,
                    Rating = 6.3,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BMjAwMjU1MTA4N15BMl5BanBnXkFtZTcwNzAxNTc3NA@@._V1_SX300.jpg"
                },
                new Movie
                {
                    Id = 10,
                    Title = "James Bond",
                    Category = category10,
                    CategoryId = category10.Id,
                    Year = 1999,
                    Rating = 5.0,
                    Poster = "https://images-na.ssl-images-amazon.com/images/M/MV5BOTJlYWYyMTUtNzQ2YS00YmYzLThkMzItOGQ0ZDA0ZWJhNjFkXkEyXkFqcGdeQXVyMjkxNzQ1NDI@._V1_SX300.jpg"
                }
            };
        }

        public List<Category> Categories {
            get; set;
        }
        public List<Movie> Movies{
            get; set;
        }
    }
}
