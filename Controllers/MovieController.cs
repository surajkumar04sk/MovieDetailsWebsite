using Microsoft.AspNetCore.Mvc;
using MovieDetailsWebsite.Models;
using MovieDetailsWebsite.Services;
using System.Threading.Tasks;

namespace MovieDetailsWebsite.Controllers
{
    public class MovieController : Controller
    {
        private readonly MovieService _movieService;

        public MovieController(MovieService movieService)
        {
            _movieService = movieService;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _movieService.GetMoviesFromDatabase();
            return View(movies);
        }

        [HttpGet]
        public IActionResult AddMovie()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddMovie(int movieId)
        {
            await _movieService.AddMovieToDatabase(movieId);
            return RedirectToAction("Index");
        }
    }
}
