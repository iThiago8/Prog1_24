using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Data;
using _240401_01.Models;

namespace _240104_01.Repository
{
    public class AddressRepository
    {
        public void Save(Address address)
        {
            DataSet.Addresses.Add(address);
        }

        public Address Retrieve(int id)
        {
            foreach (var a in DataSet.Addresses)
            {
                if (a.AddressId == id)
                    return a;                
            }

            return null;
        }
    }
}