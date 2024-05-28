using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Data;
using _240401_01.Models;

namespace _240401_01.Repository
{
    public class AddressRepository
    {
        public void Save(Address address)
        {
            address.AddressId = GetNextId();
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

        public List<Address> Retrieve()
        {
            return DataSet.Addresses;
        }

        private int GetNextId()
        {
            int n = 0;
            foreach (var a in DataSet.Addresses)
            {
                if (a.AddressId > n)
                    n = a.AddressId;
            }

            return ++n;
        }

        public void Delete(Address address)
        {
            DataSet.Addresses.Remove(address);
        }
        
    }
}