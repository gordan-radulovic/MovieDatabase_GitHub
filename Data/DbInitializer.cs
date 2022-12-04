using web.Data;
using web.Models;
using System;
using System.Linq;

namespace web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(MovieContext context)
        {
            context.Database.EnsureCreated();

            
            if (context.Movies.Any())
            {
                return;   // DB has been seeded
            }

            var movies = new Movie[]
            {
                new Movie{Name="The Shawshank Redemption",Genre=3,ReleaseDate=DateTime.Parse("2019-09-01"), Mark=9.2},
                new Movie{Name="The Godfather",Genre=2,ReleaseDate=DateTime.Parse("2019-09-01"), Mark=9.2},
                new Movie{Name="The Dark Knight",Genre=1,ReleaseDate=DateTime.Parse("2019-09-01"), Mark=9.0}
                
            };

            context.Movies.AddRange(movies);
            context.SaveChanges();

            var genres = new Genre[]
            {
                new Genre{GenreID=1,Name="Horror"},
                new Genre{GenreID=2,Name="Action"},
                new Genre{GenreID=3,Name="Commedy"}
                
            };

            context.Genres.AddRange(genres);
            context.SaveChanges();

        }
    }
}