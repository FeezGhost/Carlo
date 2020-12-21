using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentaCar.Models;

namespace RentaCar.ViewModels
{
    public class RandomCarViewModel
    {
        public Cars Car { get; set; }
        public List<Customer> Customers { get; set; }
    }
}