using System;
using System.Collections.Generic;
using System.Text;
using tesodevTask.Business.Abstract;
using tesodevTask.DataAccess.Abstract;
using tesodevTask.DataAccess.Concreate;
using tesodevTask.Entities;

namespace tesodevTask.Business.Concreate
{
    public class CustomerManager : ICustomerService
    {

        private ICustomerRepository _customerRepository;

        public CustomerManager()
        {
            _customerRepository = new CustomerRepository();
        }
        public Customer Create(Customer customer)
        {
            return _customerRepository.Create(customer);
        }

        public void Delete(Guid id)
        {
            _customerRepository.Delete(id);
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }

        public Customer GetById(Guid id)
        {
            return _customerRepository.GetById(id);
        }

        public Customer Update(Customer customer)
        {
            return _customerRepository.Update(customer);
        }
    }
}
