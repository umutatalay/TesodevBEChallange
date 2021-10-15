using System;
using System.Collections.Generic;
using System.Text;
using tesodevTask.Business.Abstract;
using tesodevTask.DataAccess.Abstract;
using tesodevTask.DataAccess.Concreate;
using tesodevTask.Entities;

namespace tesodevTask.Business.Concreate
{
    public class OrderManager : IOrderService
    {

        private IOrderRepository _orderRepository;

        public OrderManager()
        {
            _orderRepository = new OrderRepository();
        }

        public Order Create(Order order)
        {
            return _orderRepository.Create(order);
        }

        public void Delete(Guid id)
        {
            _orderRepository.Delete(id);
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public Order GetById(Guid id)
        {
            return _orderRepository.GetById(id);
        }

        public Order Update(Order order)
        {
            return _orderRepository.Update(order);
        }
    }
}
