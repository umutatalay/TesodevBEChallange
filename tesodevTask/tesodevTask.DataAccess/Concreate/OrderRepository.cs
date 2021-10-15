using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tesodevTask.DataAccess.Abstract;
using tesodevTask.Entities;

namespace tesodevTask.DataAccess.Concreate
{
    public class OrderRepository : IOrderRepository
    {
        public Order Create(Order order)
        {
            using (var TdbContext = new TdbContext())
            {
                TdbContext.Order.Add(order);
                TdbContext.SaveChanges();
                return order;

            }
        }

        public void Delete(Guid id)
        {
            using (var TdbContext = new TdbContext())
            {
                var Deleted = GetById(id);
                TdbContext.Order.Remove(Deleted);
                TdbContext.SaveChanges();
            }
        }

        public List<Order> GetAll()
        {
            using (var TdbContext = new TdbContext())
            {
                return TdbContext.Order.ToList();

            }
        }

        public Order GetById(Guid id)
        {
            using (var TdbContext = new TdbContext())
            {
                return TdbContext.Order.Find(id);
            }
        }

        public Order Update(Order order)
        {
            using (var TdbContext = new TdbContext())
            {
                TdbContext.Order.Update(order);
                TdbContext.SaveChanges();
                return order;
            }
        }
    }
}
