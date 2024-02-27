using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        private CarsDbContext _dbContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, CarsDbContext carsDbContext)
        {
            _logger = logger;
            _dbContext = carsDbContext;
        }

        public IActionResult Index()
        {
            var listOfCars = _dbContext.Cars.Include(c => c.officer);
            return View(listOfCars.ToList());
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
