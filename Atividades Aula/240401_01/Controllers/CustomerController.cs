using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Models;
using _240401_01.Repository;

namespace _240401_01.Controllers
{
    public class CustomerController
    {
        private CustomerRepository customerRepository;
        public CustomerController()
        {
            customerRepository = new();
        }
        public void Insert(Customer customer)
        {
            customerRepository.Save(customer);
        }

        public void Remove(Customer customer)
        {
            customerRepository.Delete(customer);
        }
        public Customer Get(int id)
        {
            return customerRepository.Retrieve(id);
        }
        public List<Customer> Get()
        {
            return customerRepository.Retrieve();
        }
        public List<Customer> GetByName(string name)
        {
            return customerRepository.RetrieveByName(name);
        }
    }
}