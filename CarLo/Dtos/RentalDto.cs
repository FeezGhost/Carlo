using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using CarLo.Models;

namespace CarLo.Dtos
{
    public class RentalDto
    {

        public int Id { get; set; }

        [Required]
        public byte IDCustomer { get; set; }

        [Required]
        public byte IDCar { get; set; }

        public DateTime DateRented { get; set; }

        public DateTime? DateReturned { get; set; }
    }
}