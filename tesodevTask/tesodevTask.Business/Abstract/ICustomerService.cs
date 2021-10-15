using System;
using System.Collections.Generic;
using System.Text;
using tesodevTask.Entities;

namespace tesodevTask.Business.Abstract
{
    public interface ICustomerService
    {
        List<Customer> GetAll();

        Customer GetById(Guid id);

        Customer Create(Customer customer);

        Customer Update(Customer customer);

        void Delete(Guid id);
    }
}
