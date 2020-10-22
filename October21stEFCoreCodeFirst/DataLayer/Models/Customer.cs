using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace October21stEFCoreCodeFirst.DataLayer.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public List<Order> Orders { get; set; }
    }
}
