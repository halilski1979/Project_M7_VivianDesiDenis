using MovieCatalog.Data;
using MovieCatalog.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalog.Services
{
    public class MovieService
    {
        public AppDbContext context;
        public MovieService()
        {
            this.context = new AppDbContext();
        }
        public void CreateDirector(string name, string country)
        {
            var director = new Director()
            {
                Name = name,
                Country = country
            };

            context.Directors.Add(director);
            context.SaveChanges();
        }
        public List<Director> GetAllDirectors()
        {
            return context.Directors.ToList();
        }
        public void UpdateDirector(int id, string newName, string newCountry)
        {
            var director = context.Directors.Find(id);

            if (director != null)
            {
                director.Name = newName;
                director.Country = newCountry;
                context.SaveChanges();
            }
        }
        public void DeleteDirector(int directorId)
        {
            var director = context.Directors.Find(directorId);

            if (director != null)
            {
                context.Directors.Remove(director);
                context.SaveChanges();
            }
        }
        public void AddMovie(int directorId, string title, int year)
        {
            var movie = new Movie()
            {
                DirectorId = directorId,
                Title = title,
                Year = year
            };

            context.Movies.Add(movie);
            context.SaveChanges();
        }
        public List<Movie> GetAllMovies()
        {
            return context.Movies.ToList();
        }
        public void UpdateMovie(int movieId, string newTitle, int newYear)
        {
            var movie = context.Movies.Find(movieId);

            if (movie != null)
            {
                movie.Title = newTitle;
                movie.Year = newYear;
                context.SaveChanges();
            }
        }
        public void DeleteMovie(int movieId)
        {
            var movie = context.Movies.Find(movieId);

            if (movie != null)
            {
                context.Movies.Remove(movie);
                context.SaveChanges();
            }
        }     
    }
}
