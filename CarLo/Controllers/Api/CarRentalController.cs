using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarLo.Dtos;
using CarLo.Models;
using AutoMapper;
using System.Data.Entity;

namespace CarLo.Controllers.Api
{
    public class CarRentalController : ApiController
    {
        private ApplicationDbContext _context;

        public CarRentalController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewRentals(NewRentalDto NewRental)
        {

            var customer = _context.Customers.Single(c => c.Id == NewRental.IdCustomer);
            

            var cars = _context.Cars.Where(
                c => NewRental
                .IdCars
                .Contains(c.Id))
                .ToList();
            

            foreach (var car in cars)
            {
                if (car.AvailableInstore < 1)
                    return BadRequest(car.Name+" Car is not Available");

                car.AvailableInstore--;

                var rental = new Rental
                {
                    Customer = customer,
                    Car = car,
                    DateRented = DateTime.Now,
                };

                _context.Rentals.Add(rental);

            }

            _context.SaveChanges();

            return Ok();
        }


        public IEnumerable<RentalDto> GetRentals()
        {
            return _context..ToList().Select(Mapper.Map<Rental, RentalDto>);

        }
    }
}
