using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using tesodevTask.Business.Abstract;
using tesodevTask.Business.Concreate;
using tesodevTask.Entities;

namespace tesodevTask.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private ICustomerService customerService;

        public CustomerController()
        {
            customerService = new CustomerManager();
        }
        // Create
        [HttpPost]
        public Customer Post([FromBody] Customer customer)
        {
            return customerService.Create(customer);
        }

        //Update

        [HttpPut]
        public Customer Put([FromBody] Customer customer)
        {
            return customerService.Update(customer);
        }

        // Delete 

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            customerService.Delete(id);
        }

        // Get
        [HttpGet]
        [Route("GetAll")]
        public List<Customer> GetAll()
        {
            return customerService.GetAll();
        }

        // GetByID
        [HttpGet("{id}")]
        public Customer Get(Guid id)
        {
            return customerService.GetById(id);
        }


    }
}
