using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarLo.Models
{
    public class Cars
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required(ErrorMessage ="Must specify the quantity of this car in store")]
        [Range(0, 100, ErrorMessage = "Quantity must be greater than zero")]
        public byte Instore { get; set; }

        public byte AvailableInstore { get; set; }

        public CarType CarType { get; set; }

        public byte CarTypeId { get; set; }
    }
}