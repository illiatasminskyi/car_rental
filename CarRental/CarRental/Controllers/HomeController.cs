using CarRental.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CarRental.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        CarsContext db;
        public HomeController(ILogger<HomeController> logger, CarsContext context)
        {
            _logger = logger;
            db = context;
        }

        
        public IActionResult Index()
        {
            return View(db.Cars.ToList());
        }

        public IActionResult Catalog()
        {
            return View();
        }

        public IActionResult Car()
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