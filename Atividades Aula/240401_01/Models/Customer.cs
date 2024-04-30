using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Models;

namespace _240401_01.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string? Name { get; set; }
        public string? EmailAddress { get; set; }
        public List<Address>? Addresses { get; set; } = new List<Address>();
    }
}