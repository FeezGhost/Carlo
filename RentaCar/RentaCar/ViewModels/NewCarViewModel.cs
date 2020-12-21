using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentaCar.Models;

namespace RentaCar.ViewModels
{
    public class NewCarViewModel
    {
        public IEnumerable<CarType> CarTypes{ get; set; }
        public Cars Car{ get; set; }
        public string Title
        {
            get
            {
                if (Car != null && Car.Id != 0)
                    return ("Edit Car");
                else
                    return ("New Car");
            }
        }
    }
}