using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _240318_01.models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string EmailAdress { get; set; }

        /*public Address Adress1 { get; set; }
        public Address Adress2 { get; set; }*/

        public List<Address> Addresses = 
            new List<Address>();

        public bool Validate()
        {
            return true;
        }
    }
}