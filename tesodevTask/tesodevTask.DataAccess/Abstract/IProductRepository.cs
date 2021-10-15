using System;
using System.Collections.Generic;
using System.Text;
using tesodevTask.Entities;

namespace tesodevTask.DataAccess.Abstract
{
    public interface IProductRepository
    {
        List<Product> GetAll();

        Product GetById(Guid id);

        Product Create(Product product);

        Product Update(Product product);

        void Delete(Guid id);
    }
}
