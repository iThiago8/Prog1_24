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

        public string PrintToExportDelimited()
        {
            return $"{CustomerId};{Name};{EmailAddress}";
        }

        public string PrintToExportFixed()
        {
            return String.Format("{0, -4} | {1, -30} | {2, -50} | {3, -50}", CustomerId, Name, EmailAddress, Addresses);
        }

        public override string ToString()
        {
            return "---------------------------\n"
            + $"Id: {CustomerId}\n" 
            + $"Nome: {Name} \n" 
            + $"Email: {EmailAddress}\n"  
            + "---------------------------";
        }

    }
}