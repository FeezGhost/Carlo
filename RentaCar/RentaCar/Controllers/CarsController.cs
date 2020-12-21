using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentaCar.Models;
using RentaCar.ViewModels;
using System.Data.Entity;

namespace RentaCar.Controllers
{
    public class CarsController : Controller
    {
        private ApplicationDbContext _context;

        public CarsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        public ActionResult New()
        {
            var carTypes = _context.CarTypes.ToList();
            var viewModel = new NewCarViewModel
            {
                CarTypes = carTypes
            };
            return View("New", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cars car)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new NewCarViewModel
                {
                    Car = car,
                    CarTypes = _context.CarTypes.ToList()
                };
                return View("New", viewModel);
            }
            if (car.Id == 0)
            {
                _context.Cars.Add(car);
            }
            else
            {
                var carInDB = _context.Cars.Single(c => c.Id == car.Id);
                carInDB.Name = car.Name;
                carInDB.CarTypeId = car.CarTypeId;
                carInDB.Instore = car.Instore;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Cars");
        }

        public ActionResult Edit(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => c.Id == id);
            if (car == null)
            {
                return HttpNotFound();
            }
            else
            {
                var viewModel = new NewCarViewModel
                {
                    Car = car,
                    CarTypes = _context.CarTypes.ToList()
                };
                return View("New", viewModel);
            }
        }


        // GET: Cars
        public ActionResult Random()
        {
            var car = new Cars() { Name = "XLI" };
            var customers = new List<Customer>
                {
                new Customer { Name = "Customer 1"},
                new Customer { Name = "Customer 2"}
                };
            var viewModel = new RandomCarViewModel
            {
                Car = car,
                Customers = customers
            };
            return View(viewModel);
        }
       // [Route("cars/released/{year}/{month}")]
        public ActionResult ByReleasedDate(int year, Byte month)
        {
            return Content(year+"/"+month);
        }
        public ViewResult Index()
        {
            var cars = _context.Cars.Include(c => c.CarType).ToList();

            return View(cars);
        }

        public ActionResult Details(int id)
        {
            var cars = _context.Cars.Include(c => c.CarType).SingleOrDefault(c => c.Id == id);

            if (cars == null)
                return HttpNotFound();

            return View(cars);
        }
    }
}