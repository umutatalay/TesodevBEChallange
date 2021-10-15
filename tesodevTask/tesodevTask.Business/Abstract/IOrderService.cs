using System;
using System.Collections.Generic;
using System.Text;
using tesodevTask.Entities;

namespace tesodevTask.Business.Abstract
{
    public  interface IOrderService
    {
        List<Order> GetAll();

        Order GetById(Guid id);

        Order Create(Order order);

        Order Update(Order order);

        void Delete(Guid id);
    }
}
