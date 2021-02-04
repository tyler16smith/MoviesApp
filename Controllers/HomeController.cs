using Microsoft.AspNetCore.Mvc;
using MoviesApp.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult MyPodcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult NewMovies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewMovies(NewMovies appResponse)
        {
            FullMovieList.AddApplication(appResponse);
            return View("Confirmation", appResponse);
        }

        public IActionResult Confirmation()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieList()
        {
            return View(FullMovieList.Applications);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
