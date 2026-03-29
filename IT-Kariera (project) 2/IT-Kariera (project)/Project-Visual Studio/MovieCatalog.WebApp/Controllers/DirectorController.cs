using Microsoft.AspNetCore.Mvc;
using MovieCatalog.Data.Models;
using MovieCatalog.Services;

namespace MovieCatalog.WebApp.Controllers
{
    public class DirectorController : Controller
    {
        private readonly MovieService service;

        public DirectorController(MovieService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            var directors = service.GetAllDirectors();
            return View(directors);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(string name, string country)
        {
            service.CreateDirector(name, country);
            return RedirectToAction("Index");
        }

        
        public IActionResult Delete(int id)
        {
            service.DeleteDirector(id);
            return RedirectToAction("Index");
        }
        public IActionResult AddMovie()
        {
          
            var directors = service.GetAllDirectors();
            return View(directors);
        }

        
        [HttpPost]
        public IActionResult AddMovie(int directorId, string title, int year)
        {
          
            service.AddMovie(directorId, title, year);

           
            return RedirectToAction("Index");
        }

    }
}
