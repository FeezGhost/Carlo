using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarLo.Models;

namespace CarLo.ViewModels
{
    public class RandomCarViewModel
    {
        public Cars Car { get; set; }
        public List<Customer> Customers { get; set; }
    }
}