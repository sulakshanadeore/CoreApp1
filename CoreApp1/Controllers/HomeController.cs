using CoreApp1.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CoreApp1.Controllers
{
    
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IFirst _first;

        public HomeController(ILogger<HomeController> logger,IFirst first)
        {
            _logger = logger;
            _first = first;
        }

        public IActionResult Index()
        {
            string g=_first.greet();
            ViewBag.Usergreetings = g;
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