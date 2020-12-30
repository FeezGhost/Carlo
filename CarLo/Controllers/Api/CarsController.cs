using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CarLo.Models;
using CarLo.Dtos;
using AutoMapper;
using System.Data.Entity;

namespace CarLo.Controllers.Api
{
    public class CarsController : ApiController
    {
        private ApplicationDbContext _context;

        public CarsController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<CarDto> GetCars(string query = null)
        {
            var carsQuery = _context.Cars
                .Include(c => c.CarType)
                .Where(c => c.AvailableInstore> 0);

            if (!String.IsNullOrWhiteSpace(query))
                carsQuery = carsQuery.Where(c => c.Name.Contains(query));

            return carsQuery.ToList().Select(Mapper.Map<Cars, CarDto>);
            
        }

        public IHttpActionResult GetCar(int id)
        {
            var car = _context.Cars.SingleOrDefault(c => id == c.Id);
            if (car == null)
            {
                NotFound();
            }
            return Ok(Mapper.Map<Cars,CarDto>(car));
        }

        [HttpPost]
        public IHttpActionResult CreateCar(CarDto carDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var car = Mapper.Map<CarDto, Cars>(carDto);
            _context.Cars.Add(car);
            _context.SaveChanges();
            carDto.Id = car.Id;
            return Created(new Uri(Request.RequestUri+"/"+car.Id),carDto);
        }

        [HttpPut]
        public IHttpActionResult UpdateCar(int id, CarDto carDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var carInDB = _context.Cars.SingleOrDefault(c => id == c.Id);
            if (carInDB == null)
            {
                NotFound();
            }
            Mapper.Map<CarDto, Cars>(carDto, carInDB);
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteCar(int id )
        {
            var carInDB = _context.Cars.SingleOrDefault(c => id == c.Id);
            if (carInDB == null)
            {
                return NotFound();
            }

            _context.Cars.Remove(carInDB);
            _context.SaveChanges();
            return Ok();
        }
    }
}
