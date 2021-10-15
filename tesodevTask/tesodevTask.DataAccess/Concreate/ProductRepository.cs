using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using tesodevTask.DataAccess.Abstract;
using tesodevTask.Entities;

namespace tesodevTask.DataAccess.Concreate
{
    public class ProductRepository : IProductRepository
    {
        public Product Create(Product product)
        {
            using (var TdbContext = new TdbContext())
            {
                TdbContext.Product.Add(product);
                TdbContext.SaveChanges();
                return product;

            }
        }

        public void Delete(Guid id)
        {
            using (var TdbContext = new TdbContext())
            {
                var Deleted = GetById(id);
                TdbContext.Product.Remove(Deleted);
                TdbContext.SaveChanges();
            }
        }

        public List<Product> GetAll()
        {
            using (var TdbContext = new TdbContext())
            {
                return TdbContext.Product.ToList();

            }
        }

        public Product GetById(Guid id)
        {
            using (var TdbContext = new TdbContext())
            {
                return TdbContext.Product.Find(id);
            }
        }

        public Product Update(Product product)
        {
            using (var TdbContext = new TdbContext())
            {
                TdbContext.Product.Update(product);
                TdbContext.SaveChanges();
                return product;
            }
        }
    }
}
