using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tesodevTask.DataAccess.Abstract;
using tesodevTask.Entities;

namespace tesodevTask.DataAccess.Concreate
{
    public class CustomerRepository : ICustomerRepository
    {
        public Customer Create(Customer customer)
        {
            using (var TdbContext = new TdbContext())
            {
                TdbContext.Customer.Add(customer);
                TdbContext.SaveChanges();
                return customer;

            }
        }

        public void Delete(Guid id)
        {
            using (var TdbContext = new TdbContext())
            {
                var Deleted = GetById(id);
                TdbContext.Customer.Remove(Deleted);
                TdbContext.SaveChanges();
            }
        }

        public List<Customer> GetAll()
        {
            using (var TdbContext = new TdbContext())
            {
                return TdbContext.Customer.ToList();

            }
        }

        public Customer GetById(Guid id)
        {
            using (var TdbContext = new TdbContext())
            {
                return TdbContext.Customer.Find(id);
            }
        }

        public Customer Update(Customer customer)
        {
            using (var TdbContext = new TdbContext())
            {
                TdbContext.Customer.Update(customer);
                TdbContext.SaveChanges();
                return customer;
            }
        }
    }
}
