using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using MovieCatalog.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCatalog.ConsoleUI
{
    public class CatalogConsole
    {
        private MovieService service;
        public CatalogConsole()
        {
            service = new MovieService();
        }
        public void ShowAll()
        {
            var directors = service.GetAllDirectors();
            var movies = service.GetAllMovies();

            foreach (var director in directors)
            {
                Console.WriteLine($"ID: {director.Id} | Director: {director.Name}, {director.Country}");

                foreach (var movie in movies.Where(m => m.DirectorId == director.Id))
                {
                    Console.WriteLine($"Movie ID: {movie.Id} | {movie.Title}, {movie.Year}");
                }

                Console.WriteLine("====================================");
            }
        }
        public void AddDirector()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Country: ");
            string country = Console.ReadLine();

            service.CreateDirector(name, country);
        }

        public void AddMovie()
        {
            Console.Write("Director ID: ");
            int directorId = int.Parse(Console.ReadLine());

            Console.Write("Title: ");
            string title = Console.ReadLine();

            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());

            service.AddMovie(directorId, title, year);
        }

        public void EditDirector()
        {
            Console.Write("Director ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("New Name: ");
            string newName = Console.ReadLine();

            Console.Write("New Country: ");
            string newCountry = Console.ReadLine();

            service.UpdateDirector(id, newName, newCountry);
        }

        public void EditMovie()
        {
            Console.Write("Movie ID to edit: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("New Title: ");
            string newTitle = Console.ReadLine();

            Console.Write("New Year: ");
            int year = int.Parse(Console.ReadLine());

            service.UpdateMovie(id, newTitle, year);
        }

        public void RemoveDirector()
        {
            Console.Write("Director ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            service.DeleteDirector(id);
        }

        public void RemoveMovie()
        {
            Console.Write("Movie ID to delete: ");
            int id = int.Parse(Console.ReadLine());

            service.DeleteMovie(id);
        }

        public void Run()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.Clear();
                Console.WriteLine("=== MOVIE CATALOG ===");
                Console.WriteLine("1. Print All");
                Console.WriteLine("2. Add Director");
                Console.WriteLine("3. Add Movie");
                Console.WriteLine("4. Update Director");
                Console.WriteLine("5. Update Movie");
                Console.WriteLine("6. Delete Director");
                Console.WriteLine("7. Delete Movie");
                Console.WriteLine("8. Exit");

                Console.Write("Your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": ShowAll(); break;
                    case "2": AddDirector(); break;
                    case "3": AddMovie(); break;
                    case "4": EditDirector(); break;
                    case "5": EditMovie(); break;
                    case "6": RemoveDirector(); break;
                    case "7": RemoveMovie(); break;
                    case "8": return;
                }

                if (isRunning)
                {
                    Console.WriteLine("Press any key...");
                    Console.ReadKey();
                }
            }
        }
    }
}
