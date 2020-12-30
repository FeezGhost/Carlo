using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CarLo.Dtos
{
    public class NewRentalDto
    {

        public int IdCustomer { get; set; }

        public List<int> IdCars { get; set; }
    }
}