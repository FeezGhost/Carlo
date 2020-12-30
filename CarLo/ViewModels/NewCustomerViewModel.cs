using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarLo.Models;

namespace CarLo.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }

        public string Title
        {
            get
            {
                if (Customer != null && Customer.Id != 0)
                    return ("Edit Customer");
                else
                    return ("New Customer");
            }
        }
    }
}