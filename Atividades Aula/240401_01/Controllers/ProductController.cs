using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Repository;
using _240401_01.Models;


namespace _240104_01.Controllers
{
    public class ProductController
    {
        private ProductRepository productRepository;

        public ProductController()
        {
            productRepository = new();
        }

        public void Insert(Product product)
        {
            productRepository.Save(product);
        }

        public void Remove(Product product)
        {
            productRepository.Delete(product);
        }

        public Product Get(int id)
        {
            return productRepository.Retrieve(id);
        }
    }
}