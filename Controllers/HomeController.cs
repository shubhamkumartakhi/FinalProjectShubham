using System.Diagnostics;
using EscapeResturant.Models;
using Microsoft.AspNetCore.Mvc;

namespace EscapeResturant.Controllers
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
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Menu()
        {
            return View();
        }
        public IActionResult Breakfast()
        {
            return View();
        }
        public IActionResult Lunch()
        {
            return View();
        }
        public IActionResult Dinner()
        {
            return View();
        }
        public IActionResult Chef()
        {
            return View();
        }
        public IActionResult Team()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
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
