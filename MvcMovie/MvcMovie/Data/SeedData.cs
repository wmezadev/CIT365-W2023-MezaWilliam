using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "The RM",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Comedy",
                    Rating = "R",
                    Price = 8
                },
                new Movie
                {
                    Title = "Other Side of Heaven",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Drama",
                    Rating = "R",
                    Price = 10
                },
                new Movie
                {
                    Title = "Meet the Mormons",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Documental",
                    Rating = "R",
                    Price = 9
                },
                new Movie
                {
                    Title = "Charly",
                    ReleaseDate = DateTime.Parse("2002-4-15"),
                    Genre = "Romantic",
                    Rating = "R",
                    Price = 5
                }
            );
            context.SaveChanges();
        }
    }
}