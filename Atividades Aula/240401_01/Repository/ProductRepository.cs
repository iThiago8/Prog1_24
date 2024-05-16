using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Data;
using _240401_01.Models;


namespace _240401_01.Repository
{
    public class ProductRepository
    {
        public void Save(Product product)
        {
            product.ProductId = this.GetNextId();
            DataSet.Products.Add(product);
        }

        public Product Retrieve(int id)
        {
            foreach (var p in DataSet.Products)
            {
                if (p.ProductId == id)
                    return p;
            }

            return null;
        }

        public void Delete(Product product)
        {
            DataSet.Products.Remove(product);
        }

        public int GetNextId()
        {
            int n = 0;
            foreach (var p in DataSet.Products)
            {
                if (p.ProductId > n)
                    n = p.ProductId;
            }
            return ++n;
        }
    }
}