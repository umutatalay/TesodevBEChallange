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
    public class OrderController : ControllerBase
    {

        private IOrderService orderService;

        public OrderController()
        {
            orderService = new OrderManager();
        }

        // Create
        [HttpPost]
        public Order Post([FromBody] Order order)
        {
            return orderService.Create(order);
        }

        //Update

        [HttpPut]
        public Order Put([FromBody] Order order)
        {
            return orderService.Update(order);
        }

        // Delete 

        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            orderService.Delete(id);
        }

        // Get All Order
        [HttpGet]
        [Route("GetAll")]
        public List<Order> GetAll()
        {
            return orderService.GetAll();
        }

        // GetByID
        [HttpGet("{id}")]
        public Order Get(Guid id)
        {
            return orderService.GetById(id);
        }

        [HttpPut]
        public Order ChangeStatus([FromBody] Order order)
        {
            dynamic orderstatus = order.Status;
            order.Status = !orderstatus;
            return orderService.Update(order);
        }
    }
}
