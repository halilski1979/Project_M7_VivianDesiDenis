using Microsoft.AspNetCore.Mvc;
using MovieCatalog.Services;

namespace MovieCatalog.WebApp.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieService service;

        public MovieController(MovieService service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            ViewBag.Directors = service.GetAllDirectors();
            return View();
        }
        [HttpPost]
        public IActionResult Create(int directorId, string title, int year)
        {
            service.AddMovie(directorId, title, year);
            return RedirectToAction("Index");
        }

       
        public IActionResult Delete(int id)
        {
            service.DeleteMovie(id);
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
            return RedirectToAction("Index", "Director");
        }
    }
}
