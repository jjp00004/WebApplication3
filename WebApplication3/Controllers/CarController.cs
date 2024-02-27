using Microsoft.AspNetCore.Mvc;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class CarController : Controller
    {

        private CarsDbContext _dbContext;

        public CarController(CarsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var listOfCars = _dbContext.Cars.ToList();
            return View(listOfCars);
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            Car car = _dbContext.Cars.Find(id);
                return View(car);
        }

        [HttpPost]
        public IActionResult Update(int id, [Bind("VIN, LicensePlate, Make, Model, Mileage, OfficerID")] Car Carobj) 
        { 
            if (ModelState.IsValid)
            {
                _dbContext.Cars.Update(Carobj);
                _dbContext.SaveChanges();
                return RedirectToAction("Index");

            }
            return View(Carobj);
        }
    }
}
