using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _240401_01.Data;
using _240401_01.Models;

namespace _240401_01.Repository
{
    public class OrderItemRepository
    {
        public void Save(OrderItem orderItem)
        {
            DataSet.OrderItems.Add(orderItem);
        }

        public OrderItem Retrieve(int id)
        {
            foreach(var o in DataSet.OrderItems)
            {
                if (o.OrderItemId == id)
                    return o;
            }

            return null;
        }

        public void Delete(OrderItem orderItem)
        {
            DataSet.OrderItems.Remove(orderItem);
        }
    }
}